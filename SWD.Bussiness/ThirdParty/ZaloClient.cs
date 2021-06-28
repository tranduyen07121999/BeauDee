using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.ThirdParty
{
    public interface IZaloClient
    {
        void Send();
    }
    public class ZaloClient : IZaloClient
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
