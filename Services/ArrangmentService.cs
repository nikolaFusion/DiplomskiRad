
using AutoMapper;
using Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.ErrorModels;
using Utils.Interfaces;

namespace Services
{
    public class ArrangmentService : IArrangmentService
    {
        private readonly IRepositoryArrangment _repositoryArrangment;
        private readonly IMapper _mapper;
        public ArrangmentService(IRepositoryArrangment repositoryArrangment, IMapper mapper)
        {
            _repositoryArrangment = repositoryArrangment;
            _mapper = mapper;
        }

        public async Task<List<IArrangement>> FindAllByPlaceId(string id)
        {
            int idTravelPlace;

            bool succesfullParsing = Int32.TryParse(id, out idTravelPlace);

            if (!succesfullParsing)
            {
                throw new BadRequestError("Cant parse travel place id to int");
            }

            var arrangements = await _repositoryArrangment.FindAllByPlaceId(idTravelPlace);

            return arrangements;
        }

        public async Task<List<IArrangement>> GetArrangementByFilter(string travelPlaceId,
            int numberOfPlace, DateTime startDate, DateTime endDate, double downPrice, double upPrice)
        {
            int ID;

            bool succesfullParsing=Int32.TryParse(travelPlaceId, out ID);

            if (!succesfullParsing)
            {
                throw new BadRequestError("Cant parse travel place id to int");
            }


            if (upPrice == 0)
            {
                upPrice = Double.MaxValue;
            }

            var arrangements = await _repositoryArrangment.FindByFilter(ID,numberOfPlace,
                startDate,endDate,downPrice,upPrice);

            return arrangements;
        }

        public async  Task<List<IArrangementGroup>> GetFindingArr(List<int> travelPlaceList, DateTime startDate, DateTime? endDate, int numberOfPeople)
        {

            var numberOfPlaces = travelPlaceList.Count;

            if (numberOfPlaces == 0)
            {
                return null;
            }

            try
            {


                var matrix = await getAllAppropriateArr(null, travelPlaceList, startDate, endDate, numberOfPeople);

                var argumentGroups = new List<ArrangementGroup>();

                foreach (var row in matrix)
                {
                    var arrGroup = new ArrangementGroup();
                    var listArr = new List<Arrangement>();
                    foreach (var item in row)
                    {
                        arrGroup.Price += item.Price;
                        //listArr.Add(new Arrangement(item));
                        listArr.Add(_mapper.Map<Arrangement>(item));
                    }
                    arrGroup.Arrangements = listArr;
                    argumentGroups.Add(arrGroup);
                }

                return argumentGroups.ToList<IArrangementGroup>();
            }

            catch (Exception ex)
            {
                throw new BadRequestError("Cannot return arrangements for this data");
            }
            
        }

        private async Task<List<List<IArrangement>>> getAllAppropriateArr(List<IArrangement> list,
                                                                                 List<int> travelPlaceList,
                                                                                 DateTime startDate,
                                                                                 DateTime? endDate,
                                                                                 int numberOfPeople,
                                                                                 bool last = false)
        {

            List<List<IArrangement>> endMatrix = new List<List<IArrangement>>();
            if (travelPlaceList.Count == 1)
            {
                var result=await _repositoryArrangment.GetBeforeEndDate(travelPlaceList[0],startDate,endDate,numberOfPeople,true);

                List<List<IArrangement>> matrix = new List<List<IArrangement>>();

                foreach(var res in result)
                {
                    List<IArrangement> newList = new List<IArrangement>();

                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            newList.Add(item);
                        }
                    }

                    newList.Add(res);
                    matrix.Add(newList);
                }
                return matrix;
            }

            foreach(var item in travelPlaceList)
            {
                var result = await _repositoryArrangment.GetBeforeEndDate(item, startDate, endDate, numberOfPeople, false);

                List<List<IArrangement>> matrix = new List<List<IArrangement>>();

                foreach (var res in result)
                {
                    List<IArrangement> newList = new List<IArrangement>();

                    if (list != null)
                    {
                        foreach (var arrang in list)
                        {
                            newList.Add(arrang);
                        }
                    }

                    newList.Add(res);
                    matrix.Add(newList);

                    List<int> newTravelPlaceList = new List<int>();

                    foreach (var x in travelPlaceList)
                    {
                        if (x != item)
                        {
                            newTravelPlaceList.Add(x);
                        }
                    }

                    foreach (List<IArrangement> arr in matrix)
                    {
                        var m = await getAllAppropriateArr(arr, newTravelPlaceList, arr.Last().DateEnd ?? DateTime.Now, endDate, numberOfPeople, false);

                        foreach (List<IArrangement> v in m)
                        {
                            endMatrix.Add(v);
                        }
                    }

                    matrix = new List<List<IArrangement>>();
                }
            }


            return endMatrix;
        }

    }
}
