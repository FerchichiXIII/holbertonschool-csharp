# 0x0D. C# - Text-based Interface
# InventoryManagement

This is a .NET solution for inventory management.

## InventoryLibrary

The InventoryLibrary is a class library project that contains the following classes:

### BaseClass

The `BaseClass` is the base class that other classes in the project inherit from. It defines the following properties:

- `Id`: string
- `DateCreated`: DateTime
- `DateUpdated`: DateTime

### Item

The `Item` class inherits from `BaseClass` and represents an item in the inventory. It has the following properties:

- `Name`: string (required)
- `Description`: string (optional)
- `Price`: float (optional, limited to 2 decimal points)
- `Tags`: List<string> (optional)

### User

The `User` class inherits from `BaseClass` and represents a user. It has the following properties:

- `Name`: string (required)

### Inventory

The `Inventory` class inherits from `BaseClass` and represents the inventory. It has the following properties:

- `UserId`: string (required, refers to the User's id)
- `ItemId`: string (required, refers to the Item's id)
- `Quantity`: int (default value: 1, cannot be less than 0)

## Usage

You can use the InventoryLibrary in your own projects by referencing the `InventoryLibrary.dll` assembly.

## Contributing

Contributions are welcome! If you have any suggestions, improvements, or bug fixes, please submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
