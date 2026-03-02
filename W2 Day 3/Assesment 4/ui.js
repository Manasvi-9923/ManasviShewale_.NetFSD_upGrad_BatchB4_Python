export const renderProducts = (productArray) => {

  const productList = document.getElementById("productList");

  productList.innerHTML = "";

  if (productArray.length === 0) {
    productList.innerHTML =
      `<p class="no-result">No Results Found</p>`;
    return;
  }

  productArray.forEach(product => {
    const div = document.createElement("div");
    div.classList.add("product");
    div.dataset.id = product.id;
    div.textContent = product.name;

    productList.appendChild(div);
  });
};