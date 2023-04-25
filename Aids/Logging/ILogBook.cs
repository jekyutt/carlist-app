using System;

namespace SemestriProject.Aids.Logging {

    public interface ILogBook {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }

}


