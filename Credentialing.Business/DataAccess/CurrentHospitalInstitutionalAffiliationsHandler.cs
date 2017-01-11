using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class CurrentHospitalInstitutionalAffiliationsHandler
    {
        private static CurrentHospitalInstitutionalAffiliationsHandler _instance;

        public static CurrentHospitalInstitutionalAffiliationsHandler Instance
        {
            get { return _instance ?? (_instance = new CurrentHospitalInstitutionalAffiliationsHandler()); }
        }

        private CurrentHospitalInstitutionalAffiliationsHandler()
        {
        }

        public CurrentHospitalInstitutionalAffiliations GetById(int currentHospitalInstitutionalAffiliationsId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, currentHospitalInstitutionalAffiliationsId, deepLoad);
            }
        }

        public CurrentHospitalInstitutionalAffiliations GetById(SqlConnection conn, SqlTransaction trans, int currentHospitalInstitutionalAffiliationsId, bool deepLoad = false)
        {
            CurrentHospitalInstitutionalAffiliations retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM CurrentHospitalInstitutionalAffiliations
                                                  WHERE CurrentHospitalInstitutionalAffiliationsId = @currentHospitalInstitutionalAffiliationsId", conn);
            sqlCommand.Parameters.AddWithValue("@currentHospitalInstitutionalAffiliationsId", currentHospitalInstitutionalAffiliationsId);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (var reader = sqlCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        retVal = new CurrentHospitalInstitutionalAffiliations();

                        retVal.CurrentHospitalInstitutionalAffiliationsId = (int)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentHospitalInstitutionalAffiliationsId];
                        retVal.CurrentPrimaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryAdmittingHospital] as string;
                        retVal.CurrentPrimaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryCity] as string;
                        retVal.CurrentPrimaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryState] as string;
                        retVal.CurrentPrimaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryZip] as string;
                        retVal.CurrentPrimaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryDepartmentStatus] as string;
                        retVal.CurrentPrimaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentPrimaryAppointmentDate];

                        retVal.CurrentSecondaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryAdmittingHospital] as string;
                        retVal.CurrentSecondaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryCity] as string;
                        retVal.CurrentSecondaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryState] as string;
                        retVal.CurrentSecondaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryZip] as string;
                        retVal.CurrentSecondaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryDepartmentStatus] as string;
                        retVal.CurrentSecondaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentSecondaryAppointmentDate];

                        retVal.CurrentTertiaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryAdmittingHospital] as string;
                        retVal.CurrentTertiaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryCity] as string;
                        retVal.CurrentTertiaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryState] as string;
                        retVal.CurrentTertiaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryZip] as string;
                        retVal.CurrentTertiaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryDepartmentStatus] as string;
                        retVal.CurrentTertiaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.CurrentTertiaryAppointmentDate];

                        retVal.PreviousPrimaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryAdmittingHospital] as string;
                        retVal.PreviousPrimaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryCity] as string;
                        retVal.PreviousPrimaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryState] as string;
                        retVal.PreviousPrimaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryZip] as string;
                        retVal.PreviousPrimaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryDepartmentStatus] as string;
                        retVal.PreviousPrimaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryAppointmentDate];
                        retVal.PreviousPrimaryAppointmentDateTo = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryAppointmentDateTo]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousPrimaryAppointmentDateTo];

                        retVal.PreviousSecondaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryAdmittingHospital] as string;
                        retVal.PreviousSecondaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryCity] as string;
                        retVal.PreviousSecondaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryState] as string;
                        retVal.PreviousSecondaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryZip] as string;
                        retVal.PreviousSecondaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryDepartmentStatus] as string;
                        retVal.PreviousSecondaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryAppointmentDate];
                        retVal.PreviousSecondaryAppointmentDateTo = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryAppointmentDateTo]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousSecondaryAppointmentDateTo];

                        retVal.PreviousTertiaryAdmittingHospital = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryAdmittingHospital] as string;
                        retVal.PreviousTertiaryCity = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryCity] as string;
                        retVal.PreviousTertiaryState = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryState] as string;
                        retVal.PreviousTertiaryZip = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryZip] as string;
                        retVal.PreviousTertiaryDepartmentStatus = reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryDepartmentStatus] as string;
                        retVal.PreviousTertiaryAppointmentDate = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryAppointmentDate]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryAppointmentDate];
                        retVal.PreviousTertiaryAppointmentDateTo = Convert.IsDBNull(reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryAppointmentDateTo]) ? null : (DateTime?)reader[Constants.CurrentHospitalInstitutionalAffiliationsColumns.PreviousTertiaryAppointmentDateTo];

                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            return retVal;
        }

        public int Insert(CurrentHospitalInstitutionalAffiliations info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, CurrentHospitalInstitutionalAffiliations info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO CurrentHospitalInstitutionalAffiliations
                                                    (CurrentPrimaryAdmittingHospital,
                                                     CurrentPrimaryCity,
                                                     CurrentPrimaryState, 
                                                     CurrentPrimaryZip, 
                                                     CurrentPrimaryDepartmentStatus, 
                                                     CurrentPrimaryAppointmentDate, 

                                                     CurrentSecondaryAdmittingHospital, 
                                                     CurrentSecondaryCity, 
                                                     CurrentSecondaryState, 
                                                     CurrentSecondaryZip, 
                                                     CurrentSecondaryDepartmentStatus, 
                                                     CurrentSecondaryAppointmentDate, 

                                                     CurrentTertiaryAdmittingHospital, 
                                                     CurrentTertiaryCity, 
                                                     CurrentTertiaryState, 
                                                     CurrentTertiaryZip, 
                                                     CurrentTertiaryDepartmentStatus, 
                                                     CurrentTertiaryAppointmentDate, 

                                                     PreviousPrimaryAdmittingHospital, 
                                                     PreviousPrimaryCity, 
                                                     PreviousPrimaryState, 
                                                     PreviousPrimaryZip, 
                                                     PreviousPrimaryDepartmentStatus, 
                                                     PreviousPrimaryAppointmentDate, 
                                                     PreviousPrimaryAppointmentDateTo, 

                                                     PreviousSecondaryAdmittingHospital, 
                                                     PreviousSecondaryCity, 
                                                     PreviousSecondaryState, 
                                                     PreviousSecondaryZip, 
                                                     PreviousSecondaryDepartmentStatus, 
                                                     PreviousSecondaryAppointmentDate, 
                                                     PreviousSecondaryAppointmentDateTo, 

                                                     PreviousTertiaryAdmittingHospital, 
                                                     PreviousTertiaryCity, 
                                                     PreviousTertiaryState, 
                                                     PreviousTertiaryZip, 
                                                     PreviousTertiaryDepartmentStatus, 
                                                     PreviousTertiaryAppointmentDate, 
                                                     PreviousTertiaryAppointmentDateTo, 

                                                     Completed)

                                                    OUTPUT INSERTED.CurrentHospitalInstitutionalAffiliationsId

                                                    VALUES
                                                    (@currentPrimaryAdmittingHospital, 
                                                     @currentPrimaryCity, 
                                                     @currentPrimaryState, 
                                                     @currentPrimaryZip, 
                                                     @currentPrimaryDepartmentStatus, 
                                                     @currentPrimaryAppointmentDate, 
                                                     @currentSecondaryAdmittingHospital, 
                                                     @currentSecondaryCity, 
                                                     @currentSecondaryState, 
                                                     @currentSecondaryZip, 
                                                     @currentSecondaryDepartmentStatus, 
                                                     @currentSecondaryAppointmentDate, 
                                                     @currentTertiaryAdmittingHospital, 
                                                     @currentTertiaryCity, 
                                                     @currentTertiaryState, 
                                                     @currentTertiaryZip, 
                                                     @currentTertiaryDepartmentStatus, 
                                                     @currentTertiaryAppointmentDate, 

                                                     @previousPrimaryAdmittingHospital, 
                                                     @previousPrimaryCity, 
                                                     @previousPrimaryState, 
                                                     @previousPrimaryZip, 
                                                     @previousPrimaryDepartmentStatus, 
                                                     @previousPrimaryAppointmentDate, 
                                                     @previousPrimaryAppointmentDateTo,

                                                     @previousSecondaryAdmittingHospital, 
                                                     @previousSecondaryCity, 
                                                     @previousSecondaryState, 
                                                     @previousSecondaryZip, 
                                                     @previousSecondaryDepartmentStatus, 
                                                     @previousSecondaryAppointmentDate, 
                                                     @previousSecondaryAppointmentDateTo, 

                                                     @previousTertiaryAdmittingHospital, 
                                                     @previousTertiaryCity, 
                                                     @previousTertiaryState, 
                                                     @previousTertiaryZip, 
                                                     @previousTertiaryDepartmentStatus, 
                                                     @previousTertiaryAppointmentDate, 
                                                     @previousTertiaryAppointmentDateTo, 

                                                     @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@currentHospitalInstitutionalAffiliationsId", info.CurrentHospitalInstitutionalAffiliationsId);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryAdmittingHospital", info.CurrentPrimaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryCity", info.CurrentPrimaryCity);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryState", info.CurrentPrimaryState);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryZip", info.CurrentPrimaryZip);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryDepartmentStatus", info.CurrentPrimaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryAppointmentDate", info.CurrentPrimaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@currentSecondaryAdmittingHospital", info.CurrentSecondaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryCity", info.CurrentSecondaryCity);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryState", info.CurrentSecondaryState);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryZip", info.CurrentSecondaryZip);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryDepartmentStatus", info.CurrentSecondaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryAppointmentDate", info.CurrentSecondaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@currentTertiaryAdmittingHospital", info.CurrentTertiaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryCity", info.CurrentTertiaryCity);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryState", info.CurrentTertiaryState);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryZip", info.CurrentTertiaryZip);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryDepartmentStatus", info.CurrentTertiaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryAppointmentDate", info.CurrentTertiaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@previousPrimaryAdmittingHospital", info.PreviousPrimaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryCity", info.PreviousPrimaryCity);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryState", info.PreviousPrimaryState);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryZip", info.PreviousPrimaryZip);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryDepartmentStatus", info.PreviousPrimaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryAppointmentDate", info.PreviousPrimaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryAppointmentDateTo", info.PreviousPrimaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@previousSecondaryAdmittingHospital", info.PreviousSecondaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryCity", info.PreviousSecondaryCity);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryState", info.PreviousSecondaryState);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryZip", info.PreviousSecondaryZip);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryDepartmentStatus", info.PreviousSecondaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryAppointmentDate", info.PreviousSecondaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryAppointmentDateTo", info.PreviousSecondaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@previousTertiaryAdmittingHospital", info.PreviousTertiaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryCity", info.PreviousTertiaryCity);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryState", info.PreviousTertiaryState);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryZip", info.PreviousTertiaryZip);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryDepartmentStatus", info.PreviousTertiaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryAppointmentDate", info.PreviousTertiaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryAppointmentDateTo", info.PreviousTertiaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(CurrentHospitalInstitutionalAffiliations info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, CurrentHospitalInstitutionalAffiliations info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE CurrentHospitalInstitutionalAffiliations
                                                SET
                                                    CurrentPrimaryAdmittingHospital = @currentPrimaryAdmittingHospital, 
                                                    CurrentPrimaryCity = @currentPrimaryCity, 
                                                    CurrentPrimaryState = @currentPrimaryState, 
                                                    CurrentPrimaryZip = @currentPrimaryZip, 
                                                    CurrentPrimaryDepartmentStatus = @currentPrimaryDepartmentStatus, 
                                                    CurrentPrimaryAppointmentDate = @currentPrimaryAppointmentDate, 

                                                    CurrentSecondaryAdmittingHospital = @currentSecondaryAdmittingHospital, 
                                                    CurrentSecondaryCity = @currentSecondaryCity , 
                                                    CurrentSecondaryState = @currentSecondaryState, 
                                                    CurrentSecondaryZip = @currentSecondaryZip, 
                                                    CurrentSecondaryDepartmentStatus = @currentSecondaryDepartmentStatus, 
                                                    CurrentSecondaryAppointmentDate = @currentSecondaryAppointmentDate, 

                                                    CurrentTertiaryAdmittingHospital = @currentTertiaryAdmittingHospital, 
                                                    CurrentTertiaryCity = @currentTertiaryCity, 
                                                    CurrentTertiaryState = @currentTertiaryState, 
                                                    CurrentTertiaryZip = @currentTertiaryZip, 
                                                    CurrentTertiaryDepartmentStatus = @currentTertiaryDepartmentStatus ,
                                                    CurrentTertiaryAppointmentDate = @currentTertiaryAppointmentDate, 


                                                    PreviousPrimaryAdmittingHospital = @previousPrimaryAdmittingHospital, 
                                                    PreviousPrimaryCity = @previousPrimaryCity,
                                                    PreviousPrimaryState =@previousPrimaryState ,
                                                    PreviousPrimaryZip = @previousPrimaryZip ,
                                                    PreviousPrimaryDepartmentStatus = @previousPrimaryDepartmentStatus, 
                                                    PreviousPrimaryAppointmentDate = @previousPrimaryAppointmentDate, 
                                                    PreviousPrimaryAppointmentDateTo = @previousPrimaryAppointmentDateTo, 

                                                    PreviousSecondaryAdmittingHospital = @previousSecondaryAdmittingHospital, 
                                                    PreviousSecondaryCity = @previousSecondaryCity, 
                                                    PreviousSecondaryState = @previousSecondaryState, 
                                                    PreviousSecondaryZip = @previousSecondaryZip, 
                                                    PreviousSecondaryDepartmentStatus =  @previousSecondaryDepartmentStatus, 
                                                    PreviousSecondaryAppointmentDate = @previousSecondaryAppointmentDate, 
                                                    PreviousSecondaryAppointmentDateTo = @previousSecondaryAppointmentDateTo, 

                                                    PreviousTertiaryAdmittingHospital = @previousTertiaryAdmittingHospital, 
                                                    PreviousTertiaryCity = @previousTertiaryCity , 
                                                    PreviousTertiaryState = @previousTertiaryState, 
                                                    PreviousTertiaryZip = @previousTertiaryZip, 
                                                    PreviousTertiaryDepartmentStatus =  @previousTertiaryDepartmentStatus, 
                                                    PreviousTertiaryAppointmentDate = @previousTertiaryAppointmentDate,
                                                    PreviousTertiaryAppointmentDateTo = @previousTertiaryAppointmentDateTo,

                                                    Completed = @completed

                                                WHERE CurrentHospitalInstitutionalAffiliationsId = @currentHospitalInstitutionalAffiliationsId
                                                    ", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@currentHospitalInstitutionalAffiliationsId", info.CurrentHospitalInstitutionalAffiliationsId);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryAdmittingHospital", info.CurrentPrimaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryCity", info.CurrentPrimaryCity);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryState", info.CurrentPrimaryState);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryZip", info.CurrentPrimaryZip);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryDepartmentStatus", info.CurrentPrimaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentPrimaryAppointmentDate", info.CurrentPrimaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@currentSecondaryAdmittingHospital", info.CurrentSecondaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryCity", info.CurrentSecondaryCity);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryState", info.CurrentSecondaryState);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryZip", info.CurrentSecondaryZip);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryDepartmentStatus", info.CurrentSecondaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentSecondaryAppointmentDate", info.CurrentSecondaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@currentTertiaryAdmittingHospital", info.CurrentTertiaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryCity", info.CurrentTertiaryCity);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryState", info.CurrentTertiaryState);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryZip", info.CurrentTertiaryZip);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryDepartmentStatus", info.CurrentTertiaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@currentTertiaryAppointmentDate", info.CurrentTertiaryAppointmentDate);

            sqlCommand.Parameters.AddWithValue("@previousPrimaryAdmittingHospital", info.PreviousPrimaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryCity", info.PreviousPrimaryCity);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryState", info.PreviousPrimaryState);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryZip", info.PreviousPrimaryZip);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryDepartmentStatus", info.PreviousPrimaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryAppointmentDate", info.PreviousPrimaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousPrimaryAppointmentDateTo", info.PreviousPrimaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@previousSecondaryAdmittingHospital", info.PreviousSecondaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryCity", info.PreviousSecondaryCity);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryState", info.PreviousSecondaryState);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryZip", info.PreviousSecondaryZip);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryDepartmentStatus", info.PreviousSecondaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryAppointmentDate", info.PreviousSecondaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousSecondaryAppointmentDateTo", info.PreviousSecondaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@previousTertiaryAdmittingHospital", info.PreviousTertiaryAdmittingHospital);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryCity", info.PreviousTertiaryCity);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryState", info.PreviousTertiaryState);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryZip", info.PreviousTertiaryZip);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryDepartmentStatus", info.PreviousTertiaryDepartmentStatus);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryAppointmentDate", info.PreviousTertiaryAppointmentDate);
            sqlCommand.Parameters.AddWithValue("@previousTertiaryAppointmentDateTo", info.PreviousTertiaryAppointmentDateTo);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}