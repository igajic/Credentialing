using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class ProfessionalLiabilityHandler
    {
        private static ProfessionalLiabilityHandler _instance;

        public static ProfessionalLiabilityHandler Instance
        {
            get { return _instance ?? (_instance = new ProfessionalLiabilityHandler()); }
        }

        private ProfessionalLiabilityHandler()
        {
        }

        public ProfessionalLiability GetById(int professionalLiabilityId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, professionalLiabilityId, deepLoad);
            }
        }

        public ProfessionalLiability GetById(SqlConnection conn, SqlTransaction trans, int professionalLiabilityId, bool deepLoad = false)
        {
            ProfessionalLiability retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM ProfessionalLiabilities WHERE ProfessionalLiabilityId = @professionalLiabilityId", conn);
            sqlCommand.Parameters.AddWithValue("@professionalLiabilityId", professionalLiabilityId);
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
                        retVal = new ProfessionalLiability();

                        retVal.ProfessionalLiabilityId = (int)reader[Constants.ProfessionalLiabilities.ProfessionalLiabilityId];
                        retVal.CurrentInsuranceCarrier = reader[Constants.ProfessionalLiabilities.CurrentInsuranceCarrier] as string;
                        retVal.CurrentPolicyNumber = reader[Constants.ProfessionalLiabilities.CurrentPolicyNumber] as string;
                        retVal.InitialEffectiverDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.InitialEffectiverDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.InitialEffectiverDate];
                        retVal.CurrentMailingAddress = reader[Constants.ProfessionalLiabilities.CurrentMailingAddress] as string;
                        retVal.CurrentCity = reader[Constants.ProfessionalLiabilities.CurrentCity] as string;
                        retVal.CurrentState = reader[Constants.ProfessionalLiabilities.CurrentState] as string;
                        retVal.CurrentZip = reader[Constants.ProfessionalLiabilities.CurrentZip] as string;
                        retVal.CurrentPerClaimAmount = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.CurrentPerClaimAmount]) ? null : (decimal?)reader[Constants.ProfessionalLiabilities.CurrentPerClaimAmount];
                        retVal.CurrentAggregateAmount = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.CurrentAggregateAmount]) ? null : (decimal?)reader[Constants.ProfessionalLiabilities.CurrentAggregateAmount];
                        retVal.CurrentExpirationDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.CurrentExpirationDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.CurrentExpirationDate];

                        retVal.FirstPolicyCarrierName = reader[Constants.ProfessionalLiabilities.FirstPolicyCarrierName] as string;
                        retVal.FirstPolicyNumber = reader[Constants.ProfessionalLiabilities.FirstPolicyNumber] as string;
                        retVal.FirstFromDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.FirstFromDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.FirstFromDate];
                        retVal.FirstToDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.FirstToDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.FirstToDate];
                        retVal.FirstMailingAddress = reader[Constants.ProfessionalLiabilities.FirstMailingAddress] as string;
                        retVal.FirstCity = reader[Constants.ProfessionalLiabilities.FirstCity] as string;
                        retVal.FirstState = reader[Constants.ProfessionalLiabilities.FirstState] as string;
                        retVal.FirstZip = reader[Constants.ProfessionalLiabilities.FirstZip] as string;

                        retVal.SecondPolicyCarrierName = reader[Constants.ProfessionalLiabilities.SecondPolicyCarrierName] as string;
                        retVal.SecondPolicyNumber = reader[Constants.ProfessionalLiabilities.SecondPolicyNumber] as string;
                        retVal.SecondFromDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.SecondFromDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.SecondFromDate];
                        retVal.SecondToDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.SecondToDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.SecondToDate];
                        retVal.SecondMailingAddress = reader[Constants.ProfessionalLiabilities.SecondMailingAddress] as string;
                        retVal.SecondCity = reader[Constants.ProfessionalLiabilities.SecondCity] as string;
                        retVal.SecondState = reader[Constants.ProfessionalLiabilities.SecondState] as string;
                        retVal.SecondZip = reader[Constants.ProfessionalLiabilities.SecondZip] as string;

                        retVal.ThirdPolicyCarrierName = reader[Constants.ProfessionalLiabilities.ThirdPolicyCarrierName] as string;
                        retVal.ThirdPolicyNumber = reader[Constants.ProfessionalLiabilities.ThirdPolicyNumber] as string;
                        retVal.ThirdFromDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.ThirdFromDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.ThirdFromDate];
                        retVal.ThirdToDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.ThirdToDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.ThirdToDate];
                        retVal.ThirdMailingAddress = reader[Constants.ProfessionalLiabilities.ThirdMailingAddress] as string;
                        retVal.ThirdCity = reader[Constants.ProfessionalLiabilities.ThirdCity] as string;
                        retVal.ThirdState = reader[Constants.ProfessionalLiabilities.ThirdState] as string;
                        retVal.ThirdZip = reader[Constants.ProfessionalLiabilities.ThirdZip] as string;

                        retVal.FourthPolicyCarrierName = reader[Constants.ProfessionalLiabilities.FourthPolicyCarrierName] as string;
                        retVal.FourthPolicyNumber = reader[Constants.ProfessionalLiabilities.FourthPolicyNumber] as string;
                        retVal.FourthFromDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.FourthFromDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.FourthFromDate];
                        retVal.FourthToDate = Convert.IsDBNull(reader[Constants.ProfessionalLiabilities.FourthToDate]) ? null : (DateTime?)reader[Constants.ProfessionalLiabilities.FourthToDate];
                        retVal.FourthMailingAddress = reader[Constants.ProfessionalLiabilities.FourthMailingAddress] as string;
                        retVal.FourthCity = reader[Constants.ProfessionalLiabilities.FourthCity] as string;
                        retVal.FourthState = reader[Constants.ProfessionalLiabilities.FourthState] as string;
                        retVal.FourthZip = reader[Constants.ProfessionalLiabilities.FourthZip] as string;

                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            return retVal;
        }

        public int Insert(ProfessionalLiability info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, ProfessionalLiability info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO ProfessionalLiabilities
                                                    (CurrentInsuranceCarrier, CurrentPolicyNumber, InitialEffectiverDate, CurrentMailingAddress, CurrentCity, CurrentState, CurrentZip, CurrentPerClaimAmount, CurrentAggregateAmount, CurrentExpirationDate, FirstPolicyCarrierName, FirstPolicyNumber, FirstFromDate, FirstToDate, FirstMailingAddress, FirstCity, FirstState, FirstZip, SecondPolicyCarrierName, SecondPolicyNumber, SecondFromDate, SecondToDate, SecondMailingAddress, SecondCity, SecondState, SecondZip, ThirdPolicyCarrierName, ThirdPolicyNumber, ThirdFromDate, ThirdToDate, ThirdMailingAddress, ThirdCity, ThirdState, ThirdZip, FourthPolicyCarrierName, FourthPolicyNumber, FourthFromDate, FourthToDate, FourthMailingAddress, FourthCity, FourthState, FourthZip, Completed)
                                                    OUTPUT INSERTED.ProfessionalLiabilityId
                                                    VALUES
                                                    (@currentInsuranceCarrier, @currentPolicyNumber, @initialEffectiverDate, @currentMailingAddress, @currentCity, @currentState, @currentZip, @currentPerClaimAmount, @currentAggregateAmount, @currentExpirationDate, @firstPolicyCarrierName, @firstPolicyNumber, @firstFromDate, @firstToDate, @firstMailingAddress, @firstCity, @firstState, @firstZip, @secondPolicyCarrierName, @secondPolicyNumber, @secondFromDate, @secondToDate, @secondMailingAddress, @secondCity, @secondState, @secondZip, @thirdPolicyCarrierName, @thirdPolicyNumber, @thirdFromDate, @thirdToDate, @thirdMailingAddress, @thirdCity, @thirdState, @thirdZip, @fourthPolicyCarrierName, @fourthPolicyNumber, @fourthFromDate, @fourthToDate, @fourthMailingAddress, @fourthCity, @fourthState, @fourthZip, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            //sqlCommand.Parameters.AddWithValue("@professionalLiabilityId", info.);
            sqlCommand.Parameters.AddWithValue("@currentInsuranceCarrier", info.CurrentInsuranceCarrier);
            sqlCommand.Parameters.AddWithValue("@currentPolicyNumber", info.CurrentPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@initialEffectiverDate", info.InitialEffectiverDate);
            sqlCommand.Parameters.AddWithValue("@currentMailingAddress", info.CurrentMailingAddress);
            sqlCommand.Parameters.AddWithValue("@currentCity", info.CurrentCity);
            sqlCommand.Parameters.AddWithValue("@currentState", info.CurrentState);
            sqlCommand.Parameters.AddWithValue("@currentZip", info.CurrentZip);
            sqlCommand.Parameters.AddWithValue("@currentPerClaimAmount", info.CurrentPerClaimAmount);
            sqlCommand.Parameters.AddWithValue("@currentAggregateAmount", info.CurrentAggregateAmount);
            sqlCommand.Parameters.AddWithValue("@currentExpirationDate", info.CurrentExpirationDate);
            sqlCommand.Parameters.AddWithValue("@firstPolicyCarrierName", info.FirstPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@firstPolicyNumber", info.FirstPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@firstFromDate", info.FirstFromDate);
            sqlCommand.Parameters.AddWithValue("@firstToDate", info.FirstToDate);
            sqlCommand.Parameters.AddWithValue("@firstMailingAddress", info.FirstMailingAddress);
            sqlCommand.Parameters.AddWithValue("@firstCity", info.FirstCity);
            sqlCommand.Parameters.AddWithValue("@firstState", info.FirstState);
            sqlCommand.Parameters.AddWithValue("@firstZip", info.FirstZip);

            sqlCommand.Parameters.AddWithValue("@secondPolicyCarrierName", info.SecondPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@secondPolicyNumber", info.SecondPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@secondFromDate", info.SecondFromDate);
            sqlCommand.Parameters.AddWithValue("@secondToDate", info.SecondToDate);
            sqlCommand.Parameters.AddWithValue("@secondMailingAddress", info.SecondMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondCity", info.SecondCity);
            sqlCommand.Parameters.AddWithValue("@secondState", info.SecondState);
            sqlCommand.Parameters.AddWithValue("@secondZip", info.SecondZip);

            sqlCommand.Parameters.AddWithValue("@thirdPolicyCarrierName", info.ThirdPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@thirdPolicyNumber", info.ThirdPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@thirdFromDate", info.ThirdFromDate);
            sqlCommand.Parameters.AddWithValue("@thirdToDate", info.ThirdToDate);
            sqlCommand.Parameters.AddWithValue("@thirdMailingAddress", info.ThirdMailingAddress);
            sqlCommand.Parameters.AddWithValue("@thirdCity", info.ThirdCity);
            sqlCommand.Parameters.AddWithValue("@thirdState", info.ThirdState);
            sqlCommand.Parameters.AddWithValue("@thirdZip", info.ThirdZip);

            sqlCommand.Parameters.AddWithValue("@fourthPolicyCarrierName", info.FirstPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@fourthPolicyNumber", info.FirstPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@fourthFromDate", info.FourthFromDate);
            sqlCommand.Parameters.AddWithValue("@fourthToDate", info.FourthToDate);
            sqlCommand.Parameters.AddWithValue("@fourthMailingAddress", info.FourthMailingAddress);
            sqlCommand.Parameters.AddWithValue("@fourthCity", info.FourthCity);
            sqlCommand.Parameters.AddWithValue("@fourthState", info.FourthState);
            sqlCommand.Parameters.AddWithValue("@fourthZip", info.FourthZip);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(ProfessionalLiability info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, ProfessionalLiability info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE ProfessionalLiabilities
                                                SET
                                                    CurrentInsuranceCarrier = @currentInsuranceCarrier,
                                                    CurrentPolicyNumber = @currentPolicyNumber,
                                                    InitialEffectiverDate = @initialEffectiverDate,

                                                    CurrentMailingAddress = @currentMailingAddress,
                                                    CurrentCity = @currentCity,
                                                    CurrentState = @currentState ,
                                                    CurrentZip = @currentZip,
                                                    CurrentPerClaimAmount = @currentPerClaimAmount,
                                                    CurrentAggregateAmount = @currentAggregateAmount,
                                                    CurrentExpirationDate = @currentExpirationDate,

                                                    FirstPolicyCarrierName = @firstPolicyCarrierName,
                                                    FirstPolicyNumber = @firstPolicyNumber,
                                                    FirstFromDate = @firstFromDate,
                                                    FirstToDate = @firstToDate,
                                                    FirstMailingAddress = @firstMailingAddress,
                                                    FirstCity = @firstCity ,
                                                    FirstState = @firstState,
                                                    FirstZip = @firstZip,

                                                    SecondPolicyCarrierName = @secondPolicyCarrierName,
                                                    SecondPolicyNumber = @secondPolicyNumber,
                                                    SecondFromDate = @secondFromDate,
                                                    SecondToDate = @secondToDate,
                                                    SecondMailingAddress = @secondMailingAddress,
                                                    SecondCity = @secondCity,
                                                    SecondState = @secondState,
                                                    SecondZip = @secondZip,

                                                    ThirdPolicyCarrierName = @thirdPolicyCarrierName,
                                                    ThirdPolicyNumber = @thirdPolicyNumber,
                                                    ThirdFromDate = @thirdFromDate,
                                                    ThirdToDate = @thirdToDate,
                                                    ThirdMailingAddress = @thirdMailingAddress,
                                                    ThirdCity = @thirdCity,
                                                    ThirdState = @thirdState,
                                                    ThirdZip = @thirdZip,

                                                    FourthPolicyCarrierName = @fourthPolicyCarrierName,
                                                    FourthPolicyNumber = @fourthPolicyNumber,
                                                    FourthFromDate = @fourthFromDate,
                                                    FourthToDate = @fourthToDate,
                                                    FourthMailingAddress = @fourthMailingAddress,
                                                    FourthCity = @fourthCity,
                                                    FourthState = @fourthState,
                                                    FourthZip = @fourthZip,

                                                    Completed = @completed
                                                WHERE ProfessionalLiabilityId = @professionalLiabilityId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@professionalLiabilityId", info.ProfessionalLiabilityId);
            sqlCommand.Parameters.AddWithValue("@currentInsuranceCarrier", info.CurrentInsuranceCarrier);
            sqlCommand.Parameters.AddWithValue("@currentPolicyNumber", info.CurrentPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@initialEffectiverDate", info.InitialEffectiverDate);
            sqlCommand.Parameters.AddWithValue("@currentMailingAddress", info.CurrentMailingAddress);
            sqlCommand.Parameters.AddWithValue("@currentCity", info.CurrentCity);
            sqlCommand.Parameters.AddWithValue("@currentState", info.CurrentState);
            sqlCommand.Parameters.AddWithValue("@currentZip", info.CurrentZip);
            sqlCommand.Parameters.AddWithValue("@currentPerClaimAmount", info.CurrentPerClaimAmount);
            sqlCommand.Parameters.AddWithValue("@currentAggregateAmount", info.CurrentAggregateAmount);
            sqlCommand.Parameters.AddWithValue("@currentExpirationDate", info.CurrentExpirationDate);
            sqlCommand.Parameters.AddWithValue("@firstPolicyCarrierName", info.FirstPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@firstPolicyNumber", info.FirstPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@firstFromDate", info.FirstFromDate);
            sqlCommand.Parameters.AddWithValue("@firstToDate", info.FirstToDate);
            sqlCommand.Parameters.AddWithValue("@firstMailingAddress", info.FirstMailingAddress);
            sqlCommand.Parameters.AddWithValue("@firstCity", info.FirstCity);
            sqlCommand.Parameters.AddWithValue("@firstState", info.FirstState);
            sqlCommand.Parameters.AddWithValue("@firstZip", info.FirstZip);

            sqlCommand.Parameters.AddWithValue("@secondPolicyCarrierName", info.SecondPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@secondPolicyNumber", info.SecondPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@secondFromDate", info.SecondFromDate);
            sqlCommand.Parameters.AddWithValue("@secondToDate", info.SecondToDate);
            sqlCommand.Parameters.AddWithValue("@secondMailingAddress", info.SecondMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondCity", info.SecondCity);
            sqlCommand.Parameters.AddWithValue("@secondState", info.SecondState);
            sqlCommand.Parameters.AddWithValue("@secondZip", info.SecondZip);

            sqlCommand.Parameters.AddWithValue("@thirdPolicyCarrierName", info.ThirdPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@thirdPolicyNumber", info.ThirdPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@thirdFromDate", info.ThirdFromDate);
            sqlCommand.Parameters.AddWithValue("@thirdToDate", info.ThirdToDate);
            sqlCommand.Parameters.AddWithValue("@thirdMailingAddress", info.ThirdMailingAddress);
            sqlCommand.Parameters.AddWithValue("@thirdCity", info.ThirdCity);
            sqlCommand.Parameters.AddWithValue("@thirdState", info.ThirdState);
            sqlCommand.Parameters.AddWithValue("@thirdZip", info.ThirdZip);

            sqlCommand.Parameters.AddWithValue("@fourthPolicyCarrierName", info.FirstPolicyCarrierName);
            sqlCommand.Parameters.AddWithValue("@fourthPolicyNumber", info.FirstPolicyNumber);
            sqlCommand.Parameters.AddWithValue("@fourthFromDate", info.FourthFromDate);
            sqlCommand.Parameters.AddWithValue("@fourthToDate", info.FourthToDate);
            sqlCommand.Parameters.AddWithValue("@fourthMailingAddress", info.FourthMailingAddress);
            sqlCommand.Parameters.AddWithValue("@fourthCity", info.FourthCity);
            sqlCommand.Parameters.AddWithValue("@fourthState", info.FourthState);
            sqlCommand.Parameters.AddWithValue("@fourthZip", info.FourthZip);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}