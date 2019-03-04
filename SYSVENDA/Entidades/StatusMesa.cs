using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SysVenda.Api.Data;

namespace SysVenda.Domain.Entidades
{    
    public class StatusMesa
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        private readonly string Query = @"SELECT
                                          A.CODIGO AS Codigo,
                                          A.DESCRICAO AS Descricao,
                                          'Ocupada'   AS Status
                                          FROM MESAS A JOIN
                                          COMANDAS   B ON B.MESACD = A.CODIGO
                                          WHERE B.STATUS = 'A'
                                            AND B.MESACD IS NOT NULL 
                                          
                                          UNION
                                          
                                          SELECT
                                          A.CODIGO     AS Codigo,
                                          A.DESCRICAO  AS Descricao,
                                          'Livre'      AS Status
                                          FROM MESAS A 
                                          WHERE A.CODIGO NOT IN (
                                          SELECT
                                          A.CODIGO
                                          FROM MESAS A JOIN
                                          COMANDAS B ON B.MESACD = A.CODIGO
                                          WHERE B.STATUS = 'A'
                                          AND B.MESACD IS NOT NULL 
                                          )
                                          ORDER BY DESCRICAO";

        public List<StatusMesa> GetStatusMesas()
        {
            QueryMySql queryMySql = new QueryMySql();
            var dados = queryMySql.SqlOpen(Query);

            List<StatusMesa> statusMesas = new List<StatusMesa>();
            while (dados.Read())
            {
                statusMesas.Add(new StatusMesa()
                {
                    Codigo = Convert.ToInt32(dados["Codigo"]),
                    Descricao = dados["Descricao"].ToString(),
                    Status = dados["Status"].ToString()
                });
            }

            queryMySql.SqlClose();
            return statusMesas;
        }

    }
}
