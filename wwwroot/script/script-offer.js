let image = document.querySelector(".article-image");
let scaledImageBackground = document.querySelector(".scaled-image-background");
let imageScaled;

let scale = () => {
    scaledImageBackground.classList.add("active");
}

let displayOff = () => {
    scaledImageBackground.classList.remove("active");
}

document.getElementsByClassName("image-scaled").onclick = () => {
    alert(1)
}