document.addEventListener("DOMContentLoaded", function () {
    // Example of adding products to the cart
    const addToCartButtons = document.querySelectorAll(".add-to-cart");

    addToCartButtons.forEach(button => {
        button.addEventListener("click", function () {
            alert("Product added to cart!");
            // Here you can add functionality to actually manage the cart
        });
    });
});
