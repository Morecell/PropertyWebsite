window.addEventListener("load", () => {
    const loader = document.querySelector(".loader");
    loader.classList.add("loader-hidden");

    loader.addEventListener("transtionend", () => {
        document.body.removeChild("loader");
            
    }
    )
}
)