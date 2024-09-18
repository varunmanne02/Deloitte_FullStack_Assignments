var Product = /** @class */ (function () {
    function Product(ProductId, ProductName, UnitPrice, Qty) {
        if (ProductName === void 0) { ProductName = ""; }
        if (UnitPrice === void 0) { UnitPrice = 0; }
        if (Qty === void 0) { Qty = 0; }
        this.ProductId = 0;
        this.ProductName = "";
        this.UnitPrice = 0;
        this.Qty = 0;
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.UnitPrice = UnitPrice;
        this.Qty = Qty;
    }
    Product.prototype.getTotal = function () {
        var total;
        total = this.Qty * this.UnitPrice;
        console.log("The result is ".concat(total));
    };
    Product.prototype.showDetails = function () {
        console.log("Product Id : " + this.ProductId);
        console.log("Product Name : " + this.ProductName);
        console.log("UnitPrice : " + this.UnitPrice);
        console.log("Qty : " + this.Qty);
        console.log("----------------------------");
    };
    return Product;
}());
var p1 = new Product(46545);
var p2 = new Product(46546, "Laptop", 650, 1);
var p3 = new Product(46547, "Phone", 700, 2);
var p4 = new Product(46548, "Camera", 250, 3);
p1.showDetails();
p2.showDetails();
p3.showDetails();
p2.getTotal();
