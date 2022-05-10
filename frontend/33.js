var field = document.getElementById("bgC")
var rangeRed =document.getElementById("range-red");
var rangeGreen =document.getElementById("range-green");
var rangeBlue =document.getElementById("range-blue");
var red = document.getElementById("red");
var green = document.getElementById("green");
var blue = document.getElementById("blue");

rangeRed.addEventListener("input", ()=>{
    red.textContent = "Red: " + rangeRed.value
    field.style.backgroundColor = `rgba(${rangeRed.value},${rangeGreen.value},${rangeBlue.value},1)`
    
})
rangeGreen.addEventListener("input", ()=>{
    green.textContent = "Green: " + rangeGreen.value
    field.style.backgroundColor = `rgba(${rangeRed.value},${rangeGreen.value},${rangeBlue.value},1)`
})
rangeBlue.addEventListener("input", ()=>{
    blue.textContent = "Blue: " + rangeBlue.value
    field.style.backgroundColor = `rgba(${rangeRed.value},${rangeGreen.value},${rangeBlue.value},1)`
})

field.addEventListener("click",()=>{
   navigator.clipboard.writeText(field.textContent)
   swal.fire({
       icon:"info",
       title:"Kopyalandı",
       text: field.textContent,
       footer:"Web Mobil 8 Sınıf"
   })
})