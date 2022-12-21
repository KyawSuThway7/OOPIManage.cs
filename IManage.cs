using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    public interface IManage
    {
        void CreatePost();
        double GetMoneyFromUser(double Minute,double adveradvertisment,double AppCreater);
        void YouGetMoney(double minute, double money);
        double ChangeCoverphoto(int years);
        void ChangeCoverPhotoInYear(int years, double totalphoto);
       
    }
}
