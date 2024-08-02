using System;

namespace Base.Interfaces
{
    /// <summary>
    /// Factory Design Pattern : Product interface
    /// Config repo interface 
    /// </summary>
    public interface IConfig
    {
        void Open(string connectionString);
        string ReadAll();
        void WriteAll(string blob);
    }
}
