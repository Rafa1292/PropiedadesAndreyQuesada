using Business.Cantons;
using Common;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA.Cantons
{
    public class ImplementerCanton : ICanton
    {
        public ObjectResponse<bool> Create(CantonVM cantonVM)
        {
            var canton = Mapper.MapFromVM(cantonVM);
            var response = Repository.Create(canton);

            return response;
        }

        public ObjectResponse<CantonVM> Get(int cantonId)
        {
            var response = Repository.Get(cantonId);
            if (!response.IsSuccess)
                return new ObjectResponse<CantonVM>(false, response.Message);

            var cantonVM = Mapper.MapToVM(response.Data);

            return new ObjectResponse<CantonVM>(true, response.Message, cantonVM);
        }

        public ObjectResponse<List<CantonVM>> GetAll(bool includeDeleteItems)
        {
            var cantons = Repository.GetAll(includeDeleteItems);
            if (!cantons.IsSuccess)
                return new ObjectResponse<List<CantonVM>>(false, cantons.Message);

            return new ObjectResponse<List<CantonVM>>(true, cantons.Message, Mapper.MapToVM(cantons.Data));
        }

        public ObjectResponse<bool> Update(CantonVM cantonVM)
        {
            var canton = Mapper.MapFromVM(cantonVM);
            return Repository.Update(canton);
        }

        public ObjectResponse<bool> Delete(int cantonId)
        {
            return Repository.Delete(cantonId);
        }

    }
}
