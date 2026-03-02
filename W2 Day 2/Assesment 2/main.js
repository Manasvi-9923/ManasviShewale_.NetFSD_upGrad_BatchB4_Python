

import { calculateTotal } from "./cart.js";

const cart = [
  { name: "Shirt", price: 500, quantity: 2 },
  { name: "Shoes", price: 1500, quantity: 1 },
  { name: "Cap", price: 300, quantity: 3 }
];

const total = calculateTotal(cart);

console.log(`
Invoice
--------------
Total Amount: ₹${total}
`);