using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA.Cantons
{
    public class Mapper
    {
        public static CantonVM MapToVM(Canton canton)
        {
            CantonVM cantonVM = new CantonVM()
            {
                CantonId = canton.CantonId,
                Name = canton.Name
            };

            return cantonVM;
        }

        public static Canton MapFromVM(CantonVM cantonVM)
        {
            Canton canton = new Canton()
            {
                CantonId = cantonVM.CantonId,
                Name = cantonVM.Name
            };

            return canton;
        }

        public static List<CantonVM> MapToVM(List<Canton> cantons)
        {
            List<CantonVM> cantonVM = new List<CantonVM>();

            cantons.ForEach(x => cantonVM.Add(MapToVM(x)));


            return cantonVM;
        }
    }
}
