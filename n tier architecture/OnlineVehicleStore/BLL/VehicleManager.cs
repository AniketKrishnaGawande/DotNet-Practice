namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;
public class VehicleManager
{
    public static List<Vehicle> GetVehicleDetails()
    {
        List<Vehicle> list = DBManager.GetVehiclesList();
        return list;
    }


    public static Vehicle GetVehicleDetailsById(int id)
    {
        return DBManager.GetVehicleById(id);

    }
}
