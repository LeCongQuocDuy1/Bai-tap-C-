using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Model;

namespace CRUD.Service
{
    public class ClassRoomService
    {
        public List<ClassRoom> list22= new List<ClassRoom>();
        public static List<ClassRoom> GetFakeData()
        {
            var lsClassRoom= new List<ClassRoom>();
            lsClassRoom.Add(new ClassRoom
            {
                classId = 1,
                name="Công Nghệ Thông tin",
                classTotal=10,
            });
            lsClassRoom.Add(new ClassRoom
            {
                classId = 1,
                name = "Công Nghệ Thông tin",
                classTotal = 10,
            });
            lsClassRoom.Add(new ClassRoom
            {
                classId = 1,
                name = "Công Nghệ Thông tin",
                classTotal = 10,
            });
            lsClassRoom.Add(new ClassRoom
            {
                classId = 1,
                name = "Công Nghệ Thông tin",
                classTotal = 10,

            });
            lsClassRoom.Add(new ClassRoom
            {
                classId = 1,
                name = "Công Nghệ Thông tin",
                classTotal = 10,
            });
            return lsClassRoom;
        }
    }
}
