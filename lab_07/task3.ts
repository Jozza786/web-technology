interface Product {
  id: number;
  name: string;
  price: number;
}

let product = {} as Product;
product.id = 1;
product.name = "Laptop";
product.price = 75000;
console.log(product);