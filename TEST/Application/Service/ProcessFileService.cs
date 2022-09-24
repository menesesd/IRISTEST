using Application.DTOs;
using Application.IService;
using Application.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    class ProcessFileService : IProcessFileService
    {

        public bool processFile(IFormFile file)
        {

                  
           if (file == null)
                return false;
            

            DataHash dataInfile = this.getDataAndHashFromFile(file);

            if (!dataInfile.Success)
                return false;
            

            string dataToHash = dataInfile.Data;
            string hashInFile = dataInfile.Hash;

            string hashFromData = UtilHash.getHastFromString(dataToHash);

            if (!String.IsNullOrEmpty(hashInFile))
            {
                if(hashInFile != hashFromData)
                    return false;


                //INVOCAR LAS LABMDA  LAS VALIDACIONES SOLICITADAS YA ESTAN

                //Se debe almacenar la información procesada en una tabla de DynamoDB en formato JSON.

                 //Se debe eliminar el archivo plano de S3. 


            }

            return true;
        }

        private DataHash getDataAndHashFromFile(IFormFile file)
        {
            string dataToHash = "";
            string hashInFile = "";
            IList<String> datajson = new List<String>();
            using (var reader = new System.IO.StreamReader(file.OpenReadStream(), Encoding.UTF8))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();
                    string[] data = line.Split("=");
                    if (data.Length > 1)
                    {
                        if (data[0].ToString().ToUpper().Trim() == "HASH")
                        {
                            hashInFile = data[1];
                            datajson.Add($"{line}");
                        }
                        else
                        {
                            dataToHash += data[1] + "~";
                            datajson.Add($"{line}");
                        }

                    }
                    else
                    {
                        return new DataHash
                        {
                            Data = "",
                            Hash = "",
                            Success = false,
                            Json = null

                        };
                    }
                }
            }

            return new DataHash {
                Data = dataToHash.Remove(dataToHash.Length - 1),
                Hash = hashInFile,
                Success = true,
                Json = datajson

            };
        }
    }
}
