using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class BoardCertificationHandler
    {
        private static BoardCertificationHandler _instance;

        public static BoardCertificationHandler Instance
        {
            get { return _instance ?? (_instance = new BoardCertificationHandler()); }
        }

        private BoardCertificationHandler()
        {
        }

        public BoardCertification GetById(int boardCertificationId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, boardCertificationId, deepLoad);
            }
        }

        public BoardCertification GetById(SqlConnection conn, SqlTransaction trans, int boardCertificationId, bool deepLoad = false)
        {
            BoardCertification retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM BoardCertifications
                                                  WHERE BoardCertificationId = @boardCertificationId", conn);
            sqlCommand.Parameters.AddWithValue("@boardCertificationId", boardCertificationId);
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
                        retVal = new BoardCertification();

                        retVal.BoardCertificationId = (int)reader[Constants.BoardCertificationColumns.BoardCertificationId];
                        retVal.PrimaryNameIssuingBoard = reader[Constants.BoardCertificationColumns.PrimaryNameIssuingBoard] as string;
                        retVal.PrimarySpecialty = reader[Constants.BoardCertificationColumns.PrimarySpecialty] as string;
                        retVal.PrimaryDateCertifiedRecertified = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.PrimaryDateCertifiedRecertified]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.PrimaryDateCertifiedRecertified];
                        retVal.PrimaryExpirationDate = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.PrimaryExpirationDate]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.PrimaryExpirationDate];

                        retVal.SecondaryNameIssuingBoard = reader[Constants.BoardCertificationColumns.SecondaryNameIssuingBoard] as string;
                        retVal.SecondarySpecialty = reader[Constants.BoardCertificationColumns.SecondarySpecialty] as string;
                        retVal.SecondaryDateCertifiedRecertified = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.SecondaryDateCertifiedRecertified]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.SecondaryDateCertifiedRecertified];
                        retVal.SecondaryExpirationDate = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.SecondaryExpirationDate]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.SecondaryExpirationDate];

                        retVal.TertiaryNameIssuingBoard = reader[Constants.BoardCertificationColumns.TertiaryNameIssuingBoard] as string;
                        retVal.TertiarySpecialty = reader[Constants.BoardCertificationColumns.TertiarySpecialty] as string;
                        retVal.TertiaryDateCertifiedRecertified = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.TertiaryDateCertifiedRecertified]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.TertiaryDateCertifiedRecertified];
                        retVal.TertiaryExpirationDate = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.TertiaryExpirationDate]) ? null : (DateTime?)reader[Constants.BoardCertificationColumns.TertiaryExpirationDate];

                        retVal.AdditionalBoards = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.AdditionalBoards]) ? null : (bool?)reader[Constants.BoardCertificationColumns.AdditionalBoards];
                        retVal.AdditionalListBoardsDates = reader[Constants.BoardCertificationColumns.AdditionalListBoardsDates] as string;
                        retVal.AttachmentId = Convert.IsDBNull(reader[Constants.BoardCertificationColumns.Attachment_AttachmentId]) ? null : (int?)reader[Constants.BoardCertificationColumns.Attachment_AttachmentId];
                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                if (retVal.AttachmentId.HasValue)
                {
                    retVal.Attachment = AttachmentHandler.Instance.GetById(conn, trans, retVal.AttachmentId.Value);
                }
            }

            return retVal;
        }

        public int Insert(BoardCertification info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, BoardCertification info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO BoardCertifications
                                                    (PrimaryNameIssuingBoard,  PrimarySpecialty,  PrimaryDateCertifiedRecertified,  PrimaryExpirationDate,  SecondaryNameIssuingBoard,  SecondarySpecialty,  SecondaryDateCertifiedRecertified,  SecondaryExpirationDate,  TertiaryNameIssuingBoard,  TertiarySpecialty,  TertiaryDateCertifiedRecertified,  TertiaryExpirationDate,  AdditionalBoards,  AdditionalListBoardsDates, Completed)
                                                    OUTPUT INSERTED.BoardCertificationId
                                                    VALUES
                                                    (@primaryNameIssuingBoard, @primarySpecialty, @primaryDateCertifiedRecertified, @primaryExpirationDate, @secondaryNameIssuingBoard, @secondarySpecialty, @secondaryDateCertifiedRecertified, @secondaryExpirationDate, @tertiaryNameIssuingBoard, @tertiarySpecialty, @tertiaryDateCertifiedRecertified, @tertiaryExpirationDate, @additionalBoards, @additionalListBoardsDates, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryNameIssuingBoard", info.PrimaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", info.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryDateCertifiedRecertified", info.PrimaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@primaryExpirationDate", info.PrimaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@secondaryNameIssuingBoard", info.SecondaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", info.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryDateCertifiedRecertified", info.SecondaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@secondaryExpirationDate", info.SecondaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryNameIssuingBoard", info.TertiaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", info.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryDateCertifiedRecertified", info.TertiaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@tertiaryExpirationDate", info.TertiaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@additionalBoards", info.AdditionalBoards);
            sqlCommand.Parameters.AddWithValue("@additionalListBoardsDates", info.AdditionalListBoardsDates);
            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(BoardCertification info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, BoardCertification info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE BoardCertifications
                                                SET
                                                    PrimaryNameIssuingBoard = @primaryNameIssuingBoard,
                                                    PrimarySpecialty = @primarySpecialty,
                                                    PrimaryDateCertifiedRecertified = @primaryDateCertifiedRecertified,
                                                    PrimaryExpirationDate = @primaryExpirationDate,
                                                    SecondaryNameIssuingBoard = @secondaryNameIssuingBoard,
                                                    SecondarySpecialty = @secondarySpecialty,
                                                    SecondaryDateCertifiedRecertified = @secondaryDateCertifiedRecertified,
                                                    SecondaryExpirationDate = @secondaryExpirationDate,
                                                    TertiaryNameIssuingBoard = @tertiaryNameIssuingBoard,
                                                    TertiarySpecialty = @tertiarySpecialty,
                                                    TertiaryDateCertifiedRecertified = @tertiaryDateCertifiedRecertified,
                                                    TertiaryExpirationDate = @tertiaryExpirationDate,
                                                    AdditionalBoards = @additionalBoards,
                                                    AdditionalListBoardsDates = @additionalListBoardsDates,
                                                    Attachment_AttachmentId = @attachmentId,
                                                    Completed = @completed
                                                WHERE BoardCertificationId = @boardCertificationId
                                                    ", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@boardCertificationId", info.BoardCertificationId);
            sqlCommand.Parameters.AddWithValue("@primaryNameIssuingBoard", info.PrimaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", info.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryDateCertifiedRecertified", info.PrimaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@primaryExpirationDate", info.PrimaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@secondaryNameIssuingBoard", info.SecondaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", info.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryDateCertifiedRecertified", info.SecondaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@secondaryExpirationDate", info.SecondaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryNameIssuingBoard", info.TertiaryNameIssuingBoard);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", info.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryDateCertifiedRecertified", info.TertiaryDateCertifiedRecertified);
            sqlCommand.Parameters.AddWithValue("@tertiaryExpirationDate", info.TertiaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@additionalBoards", info.AdditionalBoards);
            sqlCommand.Parameters.AddWithValue("@additionalListBoardsDates", info.AdditionalListBoardsDates);
            sqlCommand.Parameters.AddWithValue("@attachmentId", info.AttachmentId);
            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}