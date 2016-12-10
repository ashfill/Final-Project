using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Models
{
    public static class getvehicle
    {

        //public static IEnumerable<TotalAmount> getpropertiesbyusername(string builduser)
        //{
        //    FinalProject2Entities4 db = new CarProject.FinalProject2Entities4();
        //    //LinqClass Car = new LinqClass();
        //    //var properties = (from bulUser in db.TotalAmounts
        //    //                  join manuf in db.Manufacturers on bulUser.ManufacturerID equals manuf.ManufactuerID
        //    //                  join mak in db.Makes on bulUser.MakeID equals mak.MakeID
        //    //                  join eng in db.Engine1 on bulUser.Engine1ID equals eng.EngineID
        //    //                  join trans in db.transmissions on bulUser.TransmissionID equals trans.TransmissionID
        //    //                  join turb in db.turboes on bulUser.TurboID equals turb.TurboID
        //    //                  where bulUser.BuildUser == buildUser
        //    //                  select new LinqClass { Manufactuer = manuf, Make = mak, Engine = eng, transmission = trans, turbo = turb });

        //    return 

        //var myProperties = from BulUser in db.TotalAmounts
        //                   join tol in db.TotalAmounts on new { BulUser.ManufacturerID, BulUser.MakeID, BulUser.Engine1ID, BulUser.TransmissionID, BulUser.TurboID } equals new { tol.ManufacturerID, tol.MakeID, tol.Engine1ID, tol.TransmissionID, tol.TurboID }
        //                   where BulUser.BuildUser ==
        //           select tol;
        //return myProperties;
        ////}

        public static void deletemanufacturerfromuser(int buluser, int manufacturerid, int makeid, int engineid, int transid, int turbid)
        {
            using (FinalProject2Entities3 db = new CarProject.FinalProject2Entities3())
            {
                var propdelete = (from pd in db.TotalAmounts
                                  where pd.ManufacturerID == manufacturerid && pd.MakeID == makeid && pd.Engine1ID == engineid && pd.TransmissionID == transid && pd.TurboID == turbid
                                  select pd).FirstOrDefault();

                if (propdelete != null)
                {
                    db.TotalAmounts.Remove(propdelete);
                    db.SaveChanges();
                }
            }
        }

    }
}