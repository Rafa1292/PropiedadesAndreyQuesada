using Common;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Cantons
{
    public interface ICanton
    {
        public ObjectResponse<List<CantonVM>> GetAll(bool includeDeleteItems);

        public ObjectResponse<CantonVM> Get(int cantonId);


        public ObjectResponse<bool> Create(CantonVM canton);

        public ObjectResponse<bool> Update(CantonVM canton);

        public ObjectResponse<bool> Delete(int cantonId);


    }
}
