﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Favo
{
    static class FileHandler
    {
    	
        /// <summary>
        /// Reads lines of file and adds them to List
        /// </summary>
        /// <param name="path">Path of the file to be read</param>
        /// <returns>List-object indexing textfile line by line</returns>
        public static List<string> GetFileContent(string path)
        {
            // Check if wanted file actually exists
            if (!File.Exists(path))
                throw new Exception("File at path " + path + " does not exist!");



            List<string> textFileLines = new List<string>();

            // Streamreader object for reading a file
            using (StreamReader Sr = new StreamReader(path))
            {
                // line = 0 ==> Last read line did not contain any text;
                string line = Sr.ReadLine();
                while (line != null)
                {
                    textFileLines.Add(line);
                    line = Sr.ReadLine();   
                }
            }
            
            return textFileLines;
        }

        /// <summary>
        /// Writes given string to file and saves file at path
        /// </summary>
        /// <param name="path">Path of the file that has to be saved</param>
        /// <param name="content">String being written into textfile</param>
        public static void SaveFileContent (string path, string content)
        {
            // Check if file extension is .txt
            if (Path.GetExtension(path) != ".txt")
                throw new Exception("Wrong file extension! Only \".txt\" is supported");

            // Write string content to file at path
            using (StreamWriter Sw = new StreamWriter(path))
                Sw.Write(content);
        }

        /// <summary>
        ///We don't know what it does.
        /// </summary>
        public static string[] QFiller(int anzahl)
        {
            int tempIndex;
            string[] output = new string[anzahl];
            string s = global::Favo.Properties.Resources.README;

            string[] tempText = s.Split('\n');

            Random Index = new Random();
			for (int i = 0;i < anzahl; i++)
			{
        		tempIndex=Index.Next(0,tempText.Length);
        		output[i] = tempText[tempIndex];
            }
            return output;
        }
    }
}
