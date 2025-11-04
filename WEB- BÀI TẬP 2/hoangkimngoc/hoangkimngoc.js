const API_URL = "http://localhost:1880/timkiem";

function renderProducts(products) {
    const list = document.getElementById("product-list");
    list.innerHTML = "";

    if (!products || products.length === 0) {
        list.innerHTML = "<p>Không tìm thấy sản phẩm nào.</p>";
        return;
    }

    products.forEach((p) => {
        const item = document.createElement("div");
        item.className = "product";
        item.innerHTML = `
      <img src="${p.image || 'https://via.placeholder.com/230x180?text=No+Image'}" alt="${p.name}">
      <div class="product-info">
        <h3>${p.name}</h3>
        <p class="price">${Number(p.price).toLocaleString()} ₫</p>
        <p class="brand">${p.brand || "Hãng khác"} - Còn: ${p.countInStock ?? 0}</p>
      </div>
    `;
        list.appendChild(item);
    });
}

async function loadProducts(query = "") {
    try {
        let url = API_URL;
        if (query.trim() !== "") url += `?keyword=${encodeURIComponent(query)}`;
        const res = await fetch(url);
        const data = await res.json();
        renderProducts(data);
    } catch (err) {
        console.error("Lỗi khi tải sản phẩm:", err);
    }
}

document.addEventListener("DOMContentLoaded", () => {
    const searchBox = document.getElementById("searchBox");
    const searchBtn = document.getElementById("searchBtn");

    loadProducts();

    searchBtn.addEventListener("click", () => loadProducts(searchBox.value));
    searchBox.addEventListener("keypress", (e) => {
        if (e.key === "Enter") loadProducts(searchBox.value);
    });
});
