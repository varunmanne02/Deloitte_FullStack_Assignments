class Product
{
    public ProductId:number = 0;
    public ProductName:string  = "";
    public UnitPrice:number  = 0;
    public Qty:number = 0;
 
    constructor(ProductId:number, ProductName:string = "", UnitPrice:number = 0, Qty:number = 0)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.UnitPrice = UnitPrice;
        this.Qty = Qty;
    }
  
    public getTotal():void
    {
        var total:number;
        total = this.Qty*this.UnitPrice;
        console.log(`The result is ${total}`);
    }


    public showDetails():void
    {
        console.log("Product Id : " + this.ProductId);
        console.log("Product Name : " + this.ProductName);
        console.log("UnitPrice : " + this.UnitPrice);
        console.log("Qty : " + this.Qty);
        console.log("----------------------------");
    }
}



let p1:Product = new Product(46545);
let p2:Product = new Product(46546, "Laptop", 650, 1);
let p3:Product = new Product(46547, "Phone", 700, 2);
let p4:Product = new Product(46548, "Camera", 250, 3);

p1.showDetails();
p2.showDetails();
p3.showDetails();

p2.getTotal()


