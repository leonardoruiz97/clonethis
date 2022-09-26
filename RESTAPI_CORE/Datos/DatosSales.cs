﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTAPI_CORE.Entities;
using RESTAPI_CORE.Entities.enEntity;
using RESTAPI_CORE.Logica;
using System.Data;
using System.Data.SqlClient;

namespace RESTAPI_CORE.Datos
{
    public class DatosSales 
    {
        public async Task<List<enSales.responseSummary>> Lista(SqlConnection Cn, enSales.parameters parameters)
        {
            List<enSales.responseSummary> listaSales = new List<enSales.responseSummary>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "[checktur].[GetSales]",
                CommandType = CommandType.StoredProcedure,
                Connection = Cn
            };

            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", parameters.id);
            cmd.Parameters.AddWithValue("@quotation", parameters.quotation);
            cmd.Parameters.AddWithValue("@file", parameters.file);
            cmd.Parameters.AddWithValue("@correlative", parameters.correlative);
            cmd.Parameters.AddWithValue("@code", parameters.code);
            cmd.Parameters.AddWithValue("@clientId", (parameters.client == null) ? "" : parameters.client.code);
            cmd.Parameters.AddWithValue("@bussinesName", (parameters.client == null) ? "" : parameters.client.name);
            cmd.Parameters.AddWithValue("@userId", (parameters.user == null) ? "" : parameters.user.code);
            cmd.Parameters.AddWithValue("@userName", (parameters.user == null) ? "" : parameters.user.name);
            cmd.Parameters.AddWithValue("@counterId", (parameters.counter == null) ? "" : parameters.counter.code);
            cmd.Parameters.AddWithValue("@counterName", (parameters.counter == null) ? "" : parameters.counter.name);
            cmd.Parameters.AddWithValue("@creationDateIn", (parameters.creationDate == null) ? null : parameters.creationDate.In);
            cmd.Parameters.AddWithValue("@creationDateOut", (parameters.creationDate == null) ? null : parameters.creationDate.Out);
            cmd.Parameters.AddWithValue("@startDateIn", (parameters.startDate == null) ? null : parameters.startDate.In);
            cmd.Parameters.AddWithValue("@startDateOut", (parameters.startDate) == null ? null : parameters.startDate.Out);
            cmd.Parameters.AddWithValue("@outDateIn", (parameters.outDate == null) ? null : parameters.outDate.In);
            cmd.Parameters.AddWithValue("@outDateOut", (parameters.outDate == null) ? null : parameters.outDate.Out);
            cmd.Parameters.AddWithValue("@dateTimeLimitIn", (parameters.dateTimeLimit == null) ? null : parameters.dateTimeLimit.In);
            cmd.Parameters.AddWithValue("@dateTimeLimitOut", (parameters.dateTimeLimit == null) ? null : parameters.dateTimeLimit.Out);
            cmd.Parameters.AddWithValue("@status", parameters.status);
            cmd.Parameters.AddWithValue("@processStatus", parameters.processStatus);
            cmd.Parameters.AddWithValue("@new", parameters.New);
            cmd.Parameters.AddWithValue("@program", parameters.program);

            using (SqlDataReader dr = await cmd.ExecuteReaderAsync(CommandBehavior.SingleResult))
            {
                if (dr != null)
                {
                    listaSales = new List<enSales.responseSummary>();
                    while (await dr.ReadAsync())
                    {
                        listaSales.Add(new enSales.responseSummary
                        {
                            id = DAO.ToInt(dr["id"]),
                            quotation = DAO.ToString(dr["quotation"]),
                            file = DAO.ToString(dr["file"]),
                            correlative = DAO.ToString(dr["correlative"]),
                            creationDate = DAO.ToString(dr["creationDate"]),
                            title = DAO.ToString(dr["title"]),
                            travelDate = new DateEntity.range
                            {
                                In = DAO.ToString(dr["startDate"]),
                                Out = DAO.ToString(dr["outDate"])
                            },
                            days = DAO.ToInt(dr["days"]),
                            total = DAO.ToDecimal(dr["total"]),
                            status = DAO.ToString(dr["status"]),
                            processStatus = DAO.ToString(dr["processStatus"]),
                            client = new entity
                            {
                                code = DAO.ToString(dr["clientId"]),
                                name = DAO.ToString(dr["bussinesName"])
                            },
                            user = new entity
                            {
                                code = DAO.ToString(dr["userId"]),
                                name = DAO.ToString(dr["userName"])
                            },
                            counter = new entity
                            {
                                code = DAO.ToString(dr["counterId"]),
                                name = DAO.ToString(dr["counterName"])
                            }
                        });                    
                    }
                }
            }
            return listaSales;
        }
    }
}