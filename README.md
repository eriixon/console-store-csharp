# Console Store  - Zombie Gun Store
### Objective
Use CSharp to manage a virtual store
### Setup
For this project you will need to create a new Console App Solution and link it to your github account. We are going to create a simple store that manages its inventory a single item at a time. This is going to be our first of many iterations of working with a store.
### Part 1. Creating Items
Create the class Item. Each item will need at least the following properties you should be able to guess the datatypes for each
- Name
- Description
- Price

We also need a way to create items so be sure to create a constructor.
### Part 2. The Store
Create a class for the Store:
- The store should also have a constructor so we can give the store a name.
- Your store is going to be an object that has a property of Items
- Items should be a simple list of type Item

The Store class will need a few methods allowing you to add and remove items
```sh
public void AddItemToStore() {}
public void RemoveItemFromStore() {}
```

### Part 3 The Cart
Alright now lets go ahead and add a cart property to the Store class. The cart is also going to be a list of items that will be managed through the following methods:
```sh
public void AddItemToCart() {}
public void RemoveItemFromCart() {}
public void CalculateCartTotal() {}
```
### Part 4 Logging the Output (5) Points
Okay now we need an interface that a user can interact with. You will need to write out the following methods still in the Store class so we can actually build an application.
```sh
public void ViewItems() {}
public void ViewCart() {}
public Item GetItemByName(list<Item> items, string name) {}
```
### Part 5 Testing your Store (5) Bonus Points
Once you ensure this snippet works try building an actual application that lets the user add and remove items from their cart based upon console input. The user should also have a budget that they can spend. Don't let the User add an item to their cart if they don't have enough money.