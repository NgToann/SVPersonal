using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalSV.Models;
using PersonalSV.Entities;
using System.Data.SqlClient;

namespace PersonalSV.Controllers
{
    public class WorkingShiftController
    {
        public static List<WorkingShiftModel> GetAll()
        {
            List<WorkingShiftModel> workingShiftList = new List<WorkingShiftModel>();
            using (var db = new PersonalDataEntities())
            {
                //WorkingShiftModel
                var workingShiftListFromSource = db.ExecuteStoreQuery<WorkingShiftModel>("EXEC spm_SelectWorkingShiftFromSource").ToList();
                foreach (var workingShift in workingShiftListFromSource)
                {
                    if (workingShift.IsActive.ToString() == "0")
                        workingShift.Enable = true;
                    else workingShift.Disable = true;
                    if (workingShift.IsInOutManyTime.ToString() == "1")
                        workingShift.EnableInOutManyTime = true;
                    else workingShift.DisableInOutManyTime = true;
                    workingShift.WorkingShiftFullName = string.Format("{0} {1} : {2}{3}{4}{5}{6}{7}",
                                                        workingShift.WorkingShiftCode,
                                                        workingShift.WorkingShiftName,
                                                        String.IsNullOrEmpty(workingShift.TimeIn1.Trim()) == false ? workingShift.TimeIn1 : "",
                                                        String.IsNullOrEmpty(workingShift.TimeOut1.Trim()) == false ? "->" + workingShift.TimeOut1 : "",
                                                        String.IsNullOrEmpty(workingShift.TimeIn2.Trim()) == false ? "; " + workingShift.TimeIn2 : "",
                                                        String.IsNullOrEmpty(workingShift.TimeOut2.Trim()) == false ? "->" + workingShift.TimeOut2 : "",
                                                        String.IsNullOrEmpty(workingShift.TimeIn3.Trim()) == false ? "; " + workingShift.TimeIn3 : "",
                                                        String.IsNullOrEmpty(workingShift.TimeOut3.Trim()) == false ? "-> " + workingShift.TimeOut3 : "");
                    workingShiftList.Add(workingShift);
                }
            }
            return workingShiftList;
        }

        public static bool AddOrUpdate(WorkingShiftModel model)
        {
            var @WorkingShiftCode = new SqlParameter("@WorkingShiftCode", model.WorkingShiftCode);
            var @WokingShiftName = new SqlParameter("@WokingShiftName", model.WorkingShiftName != null ? model.WorkingShiftName : "");

            var @TimeIn1 = new SqlParameter("@TimeIn1", model.TimeIn1 != null ? model.TimeIn1 : "");
            var @TimeOut1 = new SqlParameter("@TimeOut1", model.TimeOut1 != null ? model.TimeOut1 : "");
            var @MinutesInOut1 = new SqlParameter("@MinutesInOut1", model.MinutesInOut1);

            var @TimeIn2 = new SqlParameter("@TimeIn2", model.TimeIn2 != null ? model.TimeIn2 : "");
            var @TimeOut2 = new SqlParameter("@TimeOut2", model.TimeOut2 != null ? model.TimeOut2 : "");
            var @MinutesInOut2 = new SqlParameter("@MinutesInOut2", model.MinutesInOut2);

            var @TimeIn3 = new SqlParameter("@TimeIn3", model.TimeIn3 != null ? model.TimeIn3 : "");
            var @TimeOut3 = new SqlParameter("@TimeOut3", model.TimeOut3 != null ? model.TimeOut3 : "");
            var @MinutesInOut3 = new SqlParameter("@MinutesInOut3", model.MinutesInOut3);

            var @WorkingDay = new SqlParameter("@WorkingDay", model.WorkingDay);
            var @WorkingHour = new SqlParameter("@WorkingHour", model.WorkingHour);
            var @TotalMinutes = new SqlParameter("@TotalMinutes", model.TotalMinutes);

            var @IsActive = new SqlParameter("@IsActive", model.Enable == true ? 0 : 1);
            var @IsInOutManyTime = new SqlParameter("@IsInOutManyTime", model.EnableInOutManyTime == true ? 1 : 0);

            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_InsertOrUpdateWorkingShift_1 @WorkingShiftCode, @WokingShiftName, @TimeIn1, @TimeOut1, @TimeIn2, @TimeOut2, @TimeIn3, @TimeOut3, @WorkingDay, @WorkingHour, @TotalMinutes, @IsActive, @MinutesInOut1, @MinutesInOut2, @MinutesInOut3, @IsInOutManyTime",
                                                                                  @WorkingShiftCode, @WokingShiftName, @TimeIn1, @TimeOut1, @TimeIn2, @TimeOut2, @TimeIn3, @TimeOut3, @WorkingDay, @WorkingHour, @TotalMinutes, @IsActive, @MinutesInOut1, @MinutesInOut2, @MinutesInOut3, @IsInOutManyTime) >= 1)
                    return true;
                else return false;
            }
        }

        public static bool Delete(WorkingShiftModel deleteModel)
        {
            var @WorkingShiftCode = new SqlParameter("@WorkingShiftCode", deleteModel.WorkingShiftCode);
            using (var db = new PersonalDataEntities())
            {
                db.CommandTimeout = 45;
                if (db.ExecuteStoreCommand("EXEC spm_DeleteWorkingShift @WorkingShiftCode", @WorkingShiftCode) >= 1)
                    return true;
                return false;
            }
        }
    }
}
