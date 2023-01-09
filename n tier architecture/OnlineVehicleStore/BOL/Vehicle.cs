namespace BOL;
public class Vehicle
{
public int VehicleId{get;set;}
public string VehicleName{get;set;}
public double ExShowroomPrice{get;set;}
public double OnRoadPrice{get;set;}

public Vehicle():this(0,"",0,0){}

public Vehicle(int id,string vName,double exPrice, double onRoadPrice)
{
VehicleId=id;
VehicleName=vName;
ExShowroomPrice=exPrice;
this.OnRoadPrice=onRoadPrice;
}
}
