using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CouncilVouingResults.Classes
{
    [DataContract]
    public class Descision
    {
        [DataMember]
        public int ID { get; private set; }
        [DataMember]
        public string DecsName { get; private set; }
        [DataMember]
        public string Yes { get; private set; }
        [DataMember]
        public string No { get; private set; }
        [DataMember]
        public string Refrained { get; private set; }
        [DataMember]
        public string DidntVote { get; private set; }
        [DataMember]
        public string HTMLPath { get; private set; }


        public Descision()
        {
        }
        public Descision(int id, string descName, string yes, string no, string refrained, string didntVote, string htmlPath)
        {
            ID = id;
            DecsName = descName;
            Yes = yes;
            No = no;
            Refrained = refrained;
            DidntVote = didntVote;
            HTMLPath = htmlPath;
        }
        public void SetDescision(int id, string descName, string yes, string no, string refrained, string didntVote, string htmlPath)
        {
            ID = id;
            DecsName = descName;
            Yes = yes;
            No = no;
            Refrained = refrained;
            DidntVote = didntVote;
            HTMLPath = htmlPath;
        }
    }
    [DataContract]
    public class Descisions
    {
        [DataMember]
        List<Descision> DescisionsList { get; set; }
        public int Count { get; private set; }
        [DataMember]
        public string Session { get; private set; }
        public Descisions()
        {
            DescisionsList = new List<Descision>();
        }

        public void SetSession(string session)
        {
            Session = session;
        }

        public void AddDescision(int id, string descName, string yes, string no, string refrained, string didntVote, string htmlPath)
        {
            DescisionsList.Add(new Descision(id, descName, yes, no, refrained, didntVote, htmlPath));
            Count = DescisionsList.Count;
        }

        public Descision this[int i]
        {
            get
            {
                if (i >= 0 && i < DescisionsList.Count)
                    return DescisionsList[i];
                else
                    throw new Exception("Index out of bounds");
            }
            set
            {
                DescisionsList[i] = value;
            }
        }
    }
    class JSON
    {
        public Descisions DescisionsList { get; private set; }
        string info;
        public JSON()
        {
            DescisionsList = new Descisions();
            info = string.Empty;
        }

        public void SetDescisions(Descisions descisions)
        {
            DescisionsList = descisions;
        }

        public void Write(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream f = new FileStream(path + "\\" + DescisionsList.Session + ".json", FileMode.Create))
            {
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(f, Encoding.UTF8, true, true))
                {
                    var ser = new DataContractJsonSerializer(typeof(Descisions));
                    ser.WriteObject(writer, DescisionsList);
                    if(!string.IsNullOrEmpty(info))
                    {

                    }
                }
            }
        }

        public Descisions Read(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new Exception("Directory for JSON READ does not exist!");
            }
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Descisions));
            using (FileStream f = new FileStream(path + "\\" + DescisionsList.Session + ".json", FileMode.Open))
            {
                DescisionsList = (Descisions)jsonFormatter.ReadObject(f);
                info = (string)jsonFormatter.ReadObject(f);
                return DescisionsList;
            }
        }

        public void CreateReadable(string path)
        {
            string[] patterns = new string[] { "\"DescisionsList\"", "\"DecsName\"", "\"DidntVote\"", "\"Yes\"", "\"No\"", "\"Refrained\"", "\"HTMLPath\"" };
            string[] replaces = new string[] { "\"Список пропозицій\"", "\"Назва пропозиції\"", "\"Не голосували\"", "\"Так\"", "\"Ні\"", "\"Утримались\"", "\"Посилання\"" };

            string[] jsonFile = File.ReadAllLines(path + "\\" + DescisionsList.Session + ".json");

            for (int i = 0; i < jsonFile.Length; i++)
            {
                for (int j = 0; j < patterns.Length; j++)
                {
                    jsonFile[i] = jsonFile[i].Replace(patterns[j], replaces[j]);
                }
            }
            
            WriteForInfo(path, jsonFile);
        }

        private void WriteForInfo(string path, string[] jsonFile)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllLines(path + "\\" + DescisionsList.Session + "_info_.json", jsonFile);
        }
    }
}