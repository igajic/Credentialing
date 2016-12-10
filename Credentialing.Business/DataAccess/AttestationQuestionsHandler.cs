using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class AttestationQuestionsHandler
    {
        private static AttestationQuestionsHandler _instance;

        public static AttestationQuestionsHandler Instance
        {
            get { return _instance ?? (_instance = new AttestationQuestionsHandler()); }
        }

        private AttestationQuestionsHandler()
        {
        }

        public AttestationQuestions GetById(int attestationQuestionsId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, attestationQuestionsId, deepLoad);
            }
        }

        public AttestationQuestions GetById(SqlConnection conn, SqlTransaction trans, int attestationQuestionsId, bool deepLoad = false)
        {
            AttestationQuestions retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM AttestationQuestions
                                                  WHERE AttestationQuestionsId = @attestationQuestionsId", conn);
            sqlCommand.Parameters.AddWithValue("@attestationQuestionsId", attestationQuestionsId);
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
                        retVal = new AttestationQuestions();

                        retVal.AttestationQuestionsId = (int)reader[Constants.AttestationQuestionsColumns.AttestationQuestionsId];
                        retVal.QuestionA = (bool)reader[Constants.AttestationQuestionsColumns.QuestionA];
                        retVal.QuestionB = (bool)reader[Constants.AttestationQuestionsColumns.QuestionB];
                        retVal.QuestionC = (bool)reader[Constants.AttestationQuestionsColumns.QuestionC];
                        retVal.QuestionD = (bool)reader[Constants.AttestationQuestionsColumns.QuestionD];
                        retVal.QuestionE = (bool)reader[Constants.AttestationQuestionsColumns.QuestionE];
                        retVal.QuestionF = (bool)reader[Constants.AttestationQuestionsColumns.QuestionF];
                        retVal.QuestionG = (bool)reader[Constants.AttestationQuestionsColumns.QuestionG];
                        retVal.QuestionH = (bool)reader[Constants.AttestationQuestionsColumns.QuestionH];
                        retVal.QuestionI = (bool)reader[Constants.AttestationQuestionsColumns.QuestionI];
                        retVal.QuestionJ = (bool)reader[Constants.AttestationQuestionsColumns.QuestionJ];
                        retVal.QuestionK = (bool)reader[Constants.AttestationQuestionsColumns.QuestionK];
                        retVal.QuestionL = (bool)reader[Constants.AttestationQuestionsColumns.QuestionL];
                        retVal.QuestionM = (bool)reader[Constants.AttestationQuestionsColumns.QuestionM];
                    }
                }

                if (deepLoad && retVal != null)
                {
                    retVal.AdditionalSheets = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "AttestationQuestionsId", retVal.AttestationQuestionsId);
                }
            }

            return retVal;
        }

        public int Insert(AttestationQuestions questions)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, questions);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, AttestationQuestions questions)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO AttestationQuestions
                                                    (QuestionA, QuestionB, QuestionC, QuestionD, QuestionE, QuestionF, QuestionG, QuestionH, QuestionI, QuestionJ, QuestionK, QuestionL, QuestionM)
                                                    OUTPUT INSERTED.BoardCertificationId
                                                    VALUES
                                                    (@questionA, @questionB, @questionC, @questionD, @questionE, @questionF, @questionG, @questionH, @questionI, @questionJ, @questionK, @questionL, @questionM)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@questionA", questions.QuestionA);
            sqlCommand.Parameters.AddWithValue("@questionB", questions.QuestionB);
            sqlCommand.Parameters.AddWithValue("@questionC", questions.QuestionC);
            sqlCommand.Parameters.AddWithValue("@questionD", questions.QuestionD);
            sqlCommand.Parameters.AddWithValue("@questionE", questions.QuestionE);
            sqlCommand.Parameters.AddWithValue("@questionF", questions.QuestionF);
            sqlCommand.Parameters.AddWithValue("@questionG", questions.QuestionG);
            sqlCommand.Parameters.AddWithValue("@questionH", questions.QuestionH);
            sqlCommand.Parameters.AddWithValue("@questionI", questions.QuestionI);
            sqlCommand.Parameters.AddWithValue("@questionJ", questions.QuestionJ);
            sqlCommand.Parameters.AddWithValue("@questionK", questions.QuestionK);
            sqlCommand.Parameters.AddWithValue("@questionL", questions.QuestionL);
            sqlCommand.Parameters.AddWithValue("@questionM", questions.QuestionM);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(AttestationQuestions questions)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, questions);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, AttestationQuestions questions)
        {
            var sqlCommand = new SqlCommand(@"UPDATE AttestationQuestions
                                                 SET
                                                    QuestionA = @questionA,
                                                    QuestionB = @questionB,
                                                    QuestionC = @questionC,
                                                    QuestionD = @questionD,
                                                    QuestionE = @questionE,
                                                    QuestionF = @questionF,
                                                    QuestionG = @questionG,
                                                    QuestionH = @questionH,
                                                    QuestionI = @questionI,
                                                    QuestionJ = @questionJ,
                                                    QuestionK = @questionK,
                                                    QuestionL = @questionL,
                                                    QuestionM = @questionM
                                                WHERE AttestationQuestions = @attestationQuestions", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@attestationQuestions", questions.AttestationQuestionsId);
            sqlCommand.Parameters.AddWithValue("@questionA", questions.QuestionA);
            sqlCommand.Parameters.AddWithValue("@questionB", questions.QuestionB);
            sqlCommand.Parameters.AddWithValue("@questionC", questions.QuestionC);
            sqlCommand.Parameters.AddWithValue("@questionD", questions.QuestionD);
            sqlCommand.Parameters.AddWithValue("@questionE", questions.QuestionE);
            sqlCommand.Parameters.AddWithValue("@questionF", questions.QuestionF);
            sqlCommand.Parameters.AddWithValue("@questionG", questions.QuestionG);
            sqlCommand.Parameters.AddWithValue("@questionH", questions.QuestionH);
            sqlCommand.Parameters.AddWithValue("@questionI", questions.QuestionI);
            sqlCommand.Parameters.AddWithValue("@questionJ", questions.QuestionJ);
            sqlCommand.Parameters.AddWithValue("@questionK", questions.QuestionK);
            sqlCommand.Parameters.AddWithValue("@questionL", questions.QuestionL);
            sqlCommand.Parameters.AddWithValue("@questionM", questions.QuestionM);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}