using System;
using System.Collections.Generic;
using System.IO;



namespace FileSearcher
{
    public class FoundInfoEventArgs
    {
        // ----- Variables -----

        private FileSystemInfo m_info;
        private String m_name;
        private List<string[]> m_parames;


        // ----- Constructor -----

        public FoundInfoEventArgs(FileSystemInfo info, String name, List<string[]> parames)
        {
            m_info = info;
            m_name = name;
            m_parames= parames;
        }


        // ----- Public Properties -----

        public FileSystemInfo Info
        {
            get { return m_info; }
        }
        
        public String Name
        {
            get { return m_name; }
        }
        
        public List<string[]> Params
        {
            get { return m_parames; }
        }
    }
}
