namespace rawr
{
    class Program
    {
        class Program
{
    static void Main(string[] args)
    {
        int levels = 2;
        int spotsPerLevel = 10;
        ParkingLot parkingLot = new ParkingLot(levels, spotsPerLevel);

        Car car1 = new Car("ABC123");
        Car car2 = new Car("DEF456");
        Truck truck1 = new Truck("GHI789");
        Motorcycle bike1 = new Motorcycle("JKL012");

        Console.WriteLine("Park Car1: " + parkingLot.ParkVehicle(car1));
        Console.WriteLine("Park Car2: " + parkingLot.ParkVehicle(car2));
        Console.WriteLine("Park Truck1: " + parkingLot.ParkVehicle(truck1));
        Console.WriteLine("Park Bike1: " + parkingLot.ParkVehicle(bike1));

        Console.WriteLine("Remove Car1: " + parkingLot.RemoveVehicle(car1));
        Console.WriteLine("Remove Car2: " + parkingLot.RemoveVehicle(car2));
    }
}
public enum VehicleSize
{
    Motorcycle,
    Compact,
    Large
}

public abstract class Vehicle
{
    protected string licensePlate;
    protected int spotsNeeded;
    protected VehicleSize size;

    public int GetSpotsNeeded() => spotsNeeded;
    public VehicleSize GetSize() => size;

    // Other common methods for vehicles
    // ...
}

public class Car : Vehicle
{
    public Car(string licensePlate)
    {
        this.licensePlate = licensePlate;
        spotsNeeded = 1;
        size = VehicleSize.Compact;
    }

    // Implement canFitinSpot method
    // ...
}

public class Truck : Vehicle
{
    public Truck(string licensePlate)
    {
        this.licensePlate = licensePlate;
        spotsNeeded = 5; // Trucks need 5 spots
        size = VehicleSize.Large;
    }

    // Implement canFitinSpot method
    // ...
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string licensePlate)
    {
        this.licensePlate = licensePlate;
        spotsNeeded = 1;
        size = VehicleSize.Motorcycle;
    }

    // Implement canFitinSpot method
    // ...
}

public class ParkingSpot
{
    private Vehicle vehicle;
    private VehicleSize spotSize;
    private int row;
    private int spotNumber;
    private Level level;

    public ParkingSpot(Level level, int row, int spotNumber, VehicleSize spotSize)
    {
        // Initialize parking spot
        // ...
    }

    public bool IsAvailable() => vehicle == null;
    public bool CanFitVehicle(Vehicle vehicle) => /* Check if vehicle can fit in this spot */;

    public bool Park(Vehicle vehicle) => /* Park vehicle in this spot */;
    public void RemoveVehicle() => /* Remove vehicle from this spot */;
}

public class Level
{
    private List<Row> rows;
    private int floorNumber;

    public Level(int floorNumber, int numRows, int numSpotsPerRow)
    {
        // Initialize level with rows and spots
        // ...
    }

    public int GetAvailableSpotsCount() => /* Calculate available spots */;
}

    }
}