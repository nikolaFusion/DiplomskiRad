
using Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services
{
    public class ArrangmentService : IArrangmentService
    {
        private readonly IRepositoryArrangment _repositoryArrangment;
        public ArrangmentService(IRepositoryArrangment repositoryArrangment)
        {
            _repositoryArrangment = repositoryArrangment;
        }
        public async  Task<List<List<IArrangement>>> GetFindingArr(List<int> travelPlaceList, DateTime startDate, DateTime? endDate, int numberOfPeople)
        {

            List<List<IArrangement>> matrix = new List<List<IArrangement>>();

            var numberOfPlaces = travelPlaceList.Count();

            if (numberOfPlaces == 0)
            {
                return null;
            }

            matrix = await getAllAppropriateArr(matrix, travelPlaceList, startDate, endDate, numberOfPeople);

            return matrix;
            
        }

        private async Task<List<List<IArrangement>>> getAllAppropriateArr(List<List<IArrangement>> matrix,List<int> travelPlaceList, DateTime startDate, DateTime? endDate, int numberOfPeople, bool last=false)
        {

            var numberOfPlaces = travelPlaceList.Count();

            if (numberOfPlaces == 0)
            {
                return matrix;
            }

            if (numberOfPlaces == 1)
            {
                last = true;
            }

            var newMatrix = new List<List<IArrangement>>();

            if (matrix.Count() == 0)
            {
                foreach (var place in travelPlaceList)
                {
                    var result =  await _repositoryArrangment.GetBeforeEndDate(place, startDate, endDate, numberOfPeople,last);

                    foreach (var arr in result)
                    {
                        var newList = new List<IArrangement>();

                        newList.Add(arr);
                        newMatrix.Add(newList);

                        travelPlaceList.Remove(place);
                        await  getAllAppropriateArr(newMatrix, travelPlaceList, (DateTime) arr.DateEnd, endDate, numberOfPeople);
                    }
                }
            }

            if (numberOfPlaces != 0)
            {

                foreach (List<IArrangement> itemList in matrix)
                {
                    foreach (var place in travelPlaceList)
                    {
                        var result = await _repositoryArrangment.GetBeforeEndDate(place, startDate, endDate, numberOfPeople,last);

                        foreach (var arr in result)
                        {
                            var newList = new List<IArrangement>();

                            foreach (var itemArrList in itemList)
                            {
                                newList.Add(itemArrList);
                            }

                            newList.Add(arr);
                            newMatrix.Add(newList);

                            travelPlaceList.Remove(place);

                            if (arr.DateEnd == null)
                            {
                                arr.DateEnd = new DateTime();
                            }

                            await getAllAppropriateArr(newMatrix, travelPlaceList, (DateTime)arr.DateEnd, endDate, numberOfPeople,last);
                        }
                    }
                }
            }
                return matrix;
        }
    }
}
