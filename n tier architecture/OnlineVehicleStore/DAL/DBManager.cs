namespace DAL;
using BOL;
public class DBManager
{


    public static List<Vehicle> GetVehiclesList()
    {

        List<Vehicle> list = new List<Vehicle>();

        list.Add(new Vehicle(100, "Lamborghini", 2000000, 2800000));
        list.Add(new Vehicle(101, "Nexon", 1000000, 1180000));
        list.Add(new Vehicle(102, "Harrier", 1800000, 1900000));
        list.Add(new Vehicle(103, "Safari", 2200000, 2400000));
        list.Add(new Vehicle(104, "brezza", 900000, 100000));
        list.Add(new Vehicle(105, "Magnite", 800000, 890000));
        return list;
    }

    public static Vehicle GetVehicleById(int id)
    {
        List<Vehicle> list = GetVehiclesList();

        foreach (Vehicle veh in list)
        {
            if (veh.VehicleId == id)
            {
                return veh;
            }
        }
        return null;
    }
}
