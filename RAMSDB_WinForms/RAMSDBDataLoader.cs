using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

using System.IO;
using System.Linq;


namespace RAMSDB.Data
{
    using DevExpress.XtraMap;
    using RAMSDBModel;
    using System.Linq;


    public partial class MapControlThis
    {
        public virtual MapControl MapControl { get { return null; } }
    }
   

    public abstract class DataLoaderBase
    {
        protected void LoadIfNeed(ref bool checkFlag, IQueryable target)
        {
            if (!checkFlag)
            {
                target.Load();
                checkFlag = true;
            }
        }
    }

    public class RAMSDBDataLoader : DataLoaderBase
    {
        RAMSDBEntities context;
        public RAMSDBDataLoader()
        {
            context = RAMSDBDataLoader.Create();
        }

        public int SaveData()
        {
            return context.SaveChanges();
        }

        public void AddNew(object toBeAdded, string sender)
        {
            if (sender == "MultiCriteriaAnalysisData")
            {
                MultiCriteriaAnalysisData add = (MultiCriteriaAnalysisData)toBeAdded;
             
                context.MultiCriteriaAnalysisData.Add(add);
                SaveData();

            }

            if (sender == "UnpavedRoadConditionSurvey")
            {
                UnpavedRoadConditionSurvey add = (UnpavedRoadConditionSurvey)toBeAdded;

                context.UnpavedRoadConditionSurvey.Add(add);
                SaveData();

            }

            if (sender == "TrafficSurvey")
            {
                TrafficSurvey add = (TrafficSurvey)toBeAdded;

                context.TrafficSurvey.Add(add);
                SaveData();

            }



         

        }

        public void Delete(object tobeDeleted, string sender)
        {
            

            if (sender == "MultiCriteriaAnalysisData")
            {
                MultiCriteriaAnalysisData delete =  (MultiCriteriaAnalysisData)tobeDeleted;
                context.MultiCriteriaAnalysisData.Attach(delete);
                context.MultiCriteriaAnalysisData.Remove(delete);

            }

            if (sender == "UnpavedRoadConditionSurvey")
            {
                UnpavedRoadConditionSurvey delete = (UnpavedRoadConditionSurvey)tobeDeleted;
                context.UnpavedRoadConditionSurvey.Attach(delete);
                context.UnpavedRoadConditionSurvey.Remove(delete);

            }

            if (sender == "TrafficSurvey")
            {
                TrafficSurvey delete = (TrafficSurvey)tobeDeleted;
                context.TrafficSurvey.Attach(delete);
                context.TrafficSurvey.Remove(delete);

            }

            









        }

        public static class LoginInfo
        {
            public static User GetLoggedInUser;

            // Roles: "Regional Admin", "Super Admin", "Woreda Data Person"

            
           
           
        }

        public static class LoggedInUser
        {
            public static string roleName = LoginInfo.GetLoggedInUser.UserRoles.Select(r => r.Role.RoleName).FirstOrDefault();
            public static string userRegion = LoginInfo.GetLoggedInUser.UserRoles.Select(r => r.Region).FirstOrDefault();
        }

        public List<RoadsPerUser> roadsPerUserDL
        {


            get
            {
                if (LoggedInUser.roleName == "Regional Admin")
                {
                    return context.RoadsPerUser.ToList();
                 //   return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.AdminBoundary.RegionName == LoggedInUser.userRegion).Select(c => c)).ToList();
                }

                if (LoggedInUser.roleName == "Woreda Data Person")
                {
                    return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.UserID == LoginInfo.GetLoggedInUser.UserID)).ToList();
                }
                else
                    return context.RoadsPerUser.ToList();

            }

        }

        public List<UnpavedRoadConditionSurvey> unpavedRoadConditionSurveysDL
        {
            get
            {

                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.UnpavedRoadConditionSurvey.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList(); 

                 
            }
        }

        public List<TentativeRoadMaintenancePlan> tentativeRoadMaintenancePlanDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.TentativeRoadMaintenancePlan.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList(); 

            }
        }


        public List<MultiCriteriaAnalysisData> multiCriteriaDataDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }

        public List<TrafficSurvey> trafficSurveysDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.TrafficSurvey.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }



        public static RAMSDBEntities Create()
        {
            //Preload().Wait();
            return new RAMSDBEntities();
        }
    }
}
