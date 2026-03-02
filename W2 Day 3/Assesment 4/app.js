import { products } from "./products.js";
import { renderProducts } from "./ui.js";

// Proper State Management
let state = {
  allProducts: products,
  filteredProducts: products
};

// Initial render
renderProducts(state.allProducts);

// Real-time filtering
const searchInput = document.getElementById("searchInput");

searchInput.addEventListener("input", (e) => {

  const searchValue = e.target.value.toLowerCase();

  state.filteredProducts =
    state.allProducts.filter(product =>
      product.name.toLowerCase().includes(searchValue)
    );

  renderProducts(state.filteredProducts);
});


// Event Delegation
const productList = document.getElementById("productList");

productList.addEventListener("click", (e) => {

  if (e.target.classList.contains("product")) {
    alert(`You clicked: ${e.target.textContent}`);
  }

});