using AutoMapper;
using Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Utils.ErrorModels;
using Utils.Interfaces;

namespace Services
{
    public class ArrangementGroupService : IArrangementGroupService
    {
        private readonly IRepositoryArranegementGroup _arrangementGroupRepo;
        private readonly IRepositoryUserArrangementGroup _userArrangementGroupRepo;
        private readonly IRepositoryArrangment _arrangementRepo;
        private readonly IMapper _mapper;

        public ArrangementGroupService(IRepositoryArranegementGroup arrangementGroupRepo,
                                        IRepositoryUserArrangementGroup userArrangementGroupRepo,
                                        IRepositoryArrangment arrangementRepo,
                                        IMapper mapper)
        {
            _mapper = mapper;
            _arrangementRepo = arrangementRepo;
            _userArrangementGroupRepo = userArrangementGroupRepo;
            _arrangementGroupRepo = arrangementGroupRepo;
        }
        public async Task<bool> Delete(string arrangementGroupID, string userID)
        {
            int id;

            bool succesfullParse=Int32.TryParse(userID, out id);

            if (!succesfullParse)
            {
                throw new BadRequestError("Invalid token");
            }

            int idArrGroup;

            bool succesfullParseArrangementGroup = Int32.TryParse(arrangementGroupID, out idArrGroup);

            if (!succesfullParseArrangementGroup)
            {
                throw new BadRequestError("Invalid arrangement group id");
            }

            var userArrangementGroup = await _userArrangementGroupRepo.GetByArrangementGroupID(id, idArrGroup);

            if (userArrangementGroup == null)
            {
                throw new BadRequestError("invalid user or arrangement group");
            }




            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {

                    await _userArrangementGroupRepo.Delete(id, idArrGroup);

                    await _arrangementGroupRepo.Delete(idArrGroup);

                    
                    scope.Complete();
                }

                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }

            return true;
        }

        public async Task<List<IArrangementGroup>> GetArrangemenyByUserId(string userID)
        {
            int id;

            bool succesfullParse = Int32.TryParse(userID, out id);

            if (!succesfullParse)
            {
                throw new BadRequestError("Invalid token");
            }

            var r = await _userArrangementGroupRepo.GetByUserId(id);

            var result = r.Select(x => x.ArrangementGroup).ToList();

            var newResult = result.Select(x => new ArrangementGroup(x)).ToList();

            var returnValue = new List<ArrangementGroup>();

            foreach(var item in newResult)
            {
                ArrangementGroup arr = new ArrangementGroup();

                arr.Price= item.Price;
                arr.ArrangementsIDs = item.ArrangementsIDs;
                arr.ArrangementGroupID = item.ArrangementGroupID;
                arr.Arrangements = new List<Arrangement>();

                foreach(var i in arr.ArrangementsIDs)
                {
                    var arrangement = await _arrangementRepo.GetByID(i);
                    arr.Arrangements.Add(new Arrangement(arrangement));
                }

                returnValue.Add(arr);
            }

            return returnValue.ToList<IArrangementGroup>();
        }

        public async Task<bool> Save( double price, string userID,List<int> arrangementsIDs)
        {
            int id;

            bool succesfullParse = Int32.TryParse(userID, out id);

            if (!succesfullParse)
            {
                throw new BadRequestError("Invalid token");
            }

            var arrangementGroupID = await _arrangementGroupRepo.GetLastID()+1;

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    ArrangementGroup arrGroup = new ArrangementGroup
                    {
                        ArrangementGroupID = arrangementGroupID,
                        ArrangementsIDs = arrangementsIDs,
                        Price = price,
                        Arrangements = new List<Arrangement>()
                     };

                    await _arrangementGroupRepo.Save(arrGroup);

                    UserArangementGroup userArrGroup = new UserArangementGroup
                    {
                        UserID = id,
                        ArrangementGroupID = arrangementGroupID
                    };
                    await _userArrangementGroupRepo.Save(userArrGroup);
                    scope.Complete();
                }

                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }

            return true;
        }
    }
}
