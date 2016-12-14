using System;
using System.Data;
using Credentialing.Entities.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;
using Credentialing.Entities;

namespace Credentialing.Business.DataAccess
{
    public class MedicalProfessionalLicensureRegistrationHandler
    {
        private static MedicalProfessionalLicensureRegistrationHandler _instance;

        public static MedicalProfessionalLicensureRegistrationHandler Instance
        {
            get { return _instance ?? (_instance = new MedicalProfessionalLicensureRegistrationHandler()); }
        }

        private MedicalProfessionalLicensureRegistrationHandler()
        {
        }

        public MedicalProfessionalLicensureRegistrations GetById(int medicalProfessionalLicensureId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, medicalProfessionalLicensureId, deepLoad);
            }
        }

        public MedicalProfessionalLicensureRegistrations GetById(SqlConnection conn, SqlTransaction trans, int medicalProfessionalLicensureId, bool deepLoad = false)
        {
            MedicalProfessionalLicensureRegistrations retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM MedicalProfessionalLicensureRegistrations WHERE MedicalProfessionalLicensureRegistrationsId = @medicalProfessionalLicensureRegistrationsId", conn);
            sqlCommand.Parameters.AddWithValue("@MedicalProfessionalLicensureRegistrationsId", medicalProfessionalLicensureId);
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
                        retVal = new MedicalProfessionalLicensureRegistrations();

                        retVal.MedicalProfessionalLicensureRegistrationsId = (int) reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.MedicalProfessionalLicensureRegistrationsId];
                        retVal.PrimaryStateMedicalLicenseNumber = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.PrimaryStateMedicalLicenseNumber] as string;
                        retVal.PrimaryStateMedicalLicenseIssueDate = Convert.IsDBNull(reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.PrimaryStateMedicalLicenseIssueDate]) ? null : (DateTime?)reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.PrimaryStateMedicalLicenseIssueDate];
                        retVal.PrimaryStateMedicalLicenseExpirationDate = Convert.IsDBNull(reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.PrimaryStateMedicalLicenseExpirationDate]) ? null : (DateTime?)reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.PrimaryStateMedicalLicenseExpirationDate];

                        retVal.DrugAdministrationNumber = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.DrugAdministrationNumber] as string;
                        retVal.DrugAdministrationExpirationDate = Convert.IsDBNull(reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.DrugAdministrationExpirationDate]) ? null : (DateTime?)reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.DrugAdministrationExpirationDate];

                        retVal.StateControlledSubstancesCertificate = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.StateControlledSubstancesCertificate] as string;
                        retVal.StateControlledSubstancesCertificateExpirationDate = Convert.IsDBNull(reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.StateControlledSubstancesCertificateExpirationDate]) ? null : (DateTime?)reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.StateControlledSubstancesCertificateExpirationDate];

                        retVal.ECFMGNumber = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.ECFMGNumber] as string;
                        retVal.ECFMGNumberIssueDate = Convert.IsDBNull(reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.ECFMGNumberIssueDate]) ? null : (DateTime?)reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.ECFMGNumberIssueDate];

                        retVal.MedicareNationalPhysicianIdentifier = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.MedicareNationalPhysicianIdentifier] as string;
                        retVal.MedicaidNumber = reader[Constants.MedicalProfessionalLicensureRegistrationsColumns.MedicaidNumber] as string;
                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            return retVal;
        }

        public int Insert(MedicalProfessionalLicensureRegistrations info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, MedicalProfessionalLicensureRegistrations info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO MedicalProfessionalLicensureRegistrations
                                                    (PrimaryStateMedicalLicenseNumber, PrimaryStateMedicalLicenseIssueDate, PrimaryStateMedicalLicenseExpirationDate, DrugAdministrationNumber, DrugAdministrationExpirationDate, StateControlledSubstancesCertificate, StateControlledSubstancesCertificateExpirationDate, ECFMGNumber, ECFMGNumberIssueDate, MedicareNationalPhysicianIdentifier, MedicaidNumber, Completed)
                                                    OUTPUT INSERTED.MedicalProfessionalLicensureRegistrationsId
                                                    VALUES
                                                    (@primaryStateMedicalLicenseNumber, @primaryStateMedicalLicenseIssueDate, @primaryStateMedicalLicenseExpirationDate, @drugAdministrationNumber, @drugAdministrationExpirationDate, @stateControlledSubstancesCertificate, @stateControlledSubstancesCertificateExpirationDate, @eCFMGNumber, @eCFMGNumberIssueDate, @medicareNationalPhysicianIdentifier, @medicaidNumber, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseNumber", info.PrimaryStateMedicalLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseIssueDate", info.PrimaryStateMedicalLicenseIssueDate);
            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseExpirationDate", info.PrimaryStateMedicalLicenseExpirationDate);

            sqlCommand.Parameters.AddWithValue("@drugAdministrationNumber", info.DrugAdministrationNumber);
            sqlCommand.Parameters.AddWithValue("@drugAdministrationExpirationDate", info.DrugAdministrationExpirationDate);

            sqlCommand.Parameters.AddWithValue("@stateControlledSubstancesCertificate", info.StateControlledSubstancesCertificate);
            sqlCommand.Parameters.AddWithValue("@stateControlledSubstancesCertificateExpirationDate", info.StateControlledSubstancesCertificateExpirationDate);

            sqlCommand.Parameters.AddWithValue("@eCFMGNumber", info.ECFMGNumber);
            sqlCommand.Parameters.AddWithValue("@eCFMGNumberIssueDate", info.ECFMGNumberIssueDate);

            sqlCommand.Parameters.AddWithValue("@medicareNationalPhysicianIdentifier", info.MedicareNationalPhysicianIdentifier);
            sqlCommand.Parameters.AddWithValue("@medicaidNumber", info.MedicaidNumber);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(MedicalProfessionalLicensureRegistrations info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, MedicalProfessionalLicensureRegistrations info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE MedicalProfessionalLicensureRegistrations
                                                SET
                                                    PrimaryStateMedicalLicenseNumber = @primaryStateMedicalLicenseNumber, 
                                                    PrimaryStateMedicalLicenseIssueDate = @primaryStateMedicalLicenseIssueDate,
                                                    PrimaryStateMedicalLicenseExpirationDate = @primaryStateMedicalLicenseExpirationDate, 
                                                    DrugAdministrationNumber = @drugAdministrationNumber, 
                                                    DrugAdministrationExpirationDate = @drugAdministrationExpirationDate, 
                                                    StateControlledSubstancesCertificate = @stateControlledSubstancesCertificate, 
                                                    StateControlledSubstancesCertificateExpirationDate = @stateControlledSubstancesCertificateExpirationDate, 
                                                    ECFMGNumber = @eCFMGNumber, 
                                                    ECFMGNumberIssueDate = @eCFMGNumberIssueDate, 
                                                    MedicareNationalPhysicianIdentifier = @medicareNationalPhysicianIdentifier, 
                                                    MedicaidNumber = @medicaidNumber,
                                                    Completed = @completed
                                                WHERE MedicalProfessionalLicensureRegistrationsId = @medicalProfessionalLicensureRegistrationsId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@medicalProfessionalLicensureRegistrationsId", info.MedicalProfessionalLicensureRegistrationsId);
            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseNumber", info.PrimaryStateMedicalLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseIssueDate", info.PrimaryStateMedicalLicenseIssueDate);
            sqlCommand.Parameters.AddWithValue("@primaryStateMedicalLicenseExpirationDate", info.PrimaryStateMedicalLicenseExpirationDate);

            sqlCommand.Parameters.AddWithValue("@drugAdministrationNumber", info.DrugAdministrationNumber);
            sqlCommand.Parameters.AddWithValue("@drugAdministrationExpirationDate", info.DrugAdministrationExpirationDate);

            sqlCommand.Parameters.AddWithValue("@stateControlledSubstancesCertificate", info.StateControlledSubstancesCertificate);
            sqlCommand.Parameters.AddWithValue("@stateControlledSubstancesCertificateExpirationDate", info.StateControlledSubstancesCertificateExpirationDate);

            sqlCommand.Parameters.AddWithValue("@eCFMGNumber", info.ECFMGNumber);
            sqlCommand.Parameters.AddWithValue("@eCFMGNumberIssueDate", info.ECFMGNumberIssueDate);

            sqlCommand.Parameters.AddWithValue("@medicareNationalPhysicianIdentifier", info.MedicareNationalPhysicianIdentifier);
            sqlCommand.Parameters.AddWithValue("@medicaidNumber", info.MedicaidNumber);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}