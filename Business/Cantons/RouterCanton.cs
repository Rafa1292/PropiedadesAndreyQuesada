using Common;
using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Cantons
{
    public class RouterCanton
    {
        private readonly ICanton _canton;

        public RouterCanton(ICanton canton)
        {
            _canton = canton;
        }

        public ObjectResponse<List<CantonVM>> GetAll()
        {
            return _canton.GetAll(false);
        }

        public ObjectResponse<CantonVM> Get(int cantonId)
        {
            return _canton.Get(cantonId);
        }

        public ObjectResponse<bool> Create(CantonVM canton)
        {
            return _canton.Create(canton);
        }

        public ObjectResponse<bool> Update(CantonVM canton)
        {
            return _canton.Update(canton);
        }

        public ObjectResponse<bool> Delete(int cantonId)
        {
            return _canton.Delete(cantonId);
        }
    }
}
