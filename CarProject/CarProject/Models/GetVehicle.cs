using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Models
{
    public static class getvehicle
    {

        public static IEnumerable<TotalAmount> GetBuildsByUserName(string user)
        {
            FinalProject3Entities1 db = new CarProject.FinalProject3Entities1();

            //var Cars = from BulUser in db.TotalAmounts
            //           join U in db.TotalAmounts on new {BulUser.MakeID, BulUser.EngineID, BulUser.TransmissionID, BulUser.TurboID, BulUser.CarModelID,BulUser.TotalCost } equals new {U.MakeID, U.EngineID, U.TransmissionID, U.TurboID, U.CarModelID, U.TotalCost }
            //           where BulUser.BuildUser == user
            //      select U;
            var Cars = from BulUser in db.TotalAmounts
                       where BulUser.BuildUser == user
                       select BulUser;
        return Cars;
        }

        //public static void deleteBuildfromuser(string buluser, int manufacturerid)
        //{
        //    using (FinalProject3Entities2 db = new CarProject.FinalProject3Entities2())
        //    {
        //        var propdelete = (from pd in db.TotalAmounts
        //                          where pd.ManufacturerID == manufacturerid && pd.BuildUser == buluser
        //                          select pd).FirstOrDefault();

        //        if (propdelete != null)
        //        {
        //            db.TotalAmounts.Remove(propdelete);
        //            db.SaveChanges();
        //        }
            }
        }
    
                       


        //public static void User(TotalAmount amount)
        //{
        //    FinalProject2Entities3 db = new CarProject.FinalProject2Entities3();

        //    TotalAmount checkuser = (from m in db.TotalAmounts
        //                        where m.Engine1ID == amount.Engine1ID && m.MakeID == amount.MakeID && m.ManufacturerID == amount.ManufacturerID && m.TransmissionID==amount.TransmissionID && m.TurboID==amount.TurboID
        //                        select m).FirstOrDefault();

        //    if (checkuser == null)
        //    {
        //        db.TotalAmounts.Add(amount);
        //        db.SaveChanges();
        //        checkuser = db.TotalAmounts.Where(m => m.Engine1ID == amount.Engine1ID && m.MakeID == amount.MakeID && m.ManufacturerID == amount.ManufacturerID && m.TransmissionID == amount.TransmissionID && m.TurboID == amount.TurboID).FirstOrDefault();
        //    }

        //    checkuser.TotalAmountID = checkuser.TotalAmountID;
        //    db.MovieUsers.Add(movieUser);
        //    db.SaveChanges();
        //}

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

       
            

        //public static void deletemanufacturerfromuser(int buluser, int manufacturerid, int makeid, int engineid, int transid, int turbid)
        //{
        //    using (FinalProject2Entities3 db = new CarProject.FinalProject2Entities3())
        //    {
        //        var propdelete = (from pd in db.TotalAmounts
        //                          where pd.ManufacturerID == manufacturerid && pd.MakeID == makeid && pd.Engine1ID == engineid && pd.TransmissionID == transid && pd.TurboID == turbid
        //                          select pd).FirstOrDefault();

        //        if (propdelete != null)
        //        {
        //            db.TotalAmounts.Remove(propdelete);
        //            db.SaveChanges();
        //        }
            
        

    
