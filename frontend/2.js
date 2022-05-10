console.log("2 ok");

//operatörler
//Matematiksel operatörler
// + - * / % 
// ++ -- **
//+= -= *= /= %=
//Mantıksal Operatörler
//< > <= >= == ! != === !== && || 
function kontrol() {
    var a = 10;
    var b = "10";
    console.log("a = " + typeof a)
    console.log("b = " + typeof b)
    if (a == b && typeof a == typeof b) {
        //=== çalışma mantığı
        console.log("a=b");

    } else {
        console.log("a!=b");
    }

    console.log(a * b);
}

function faktoriyel(n) {
    var sonuc = 1;
    for (var i = 1; i <= n; i++) {
        sonuc *= i;

    }
    return sonuc;

}

var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
function diziDongu() {
    console.log("for");
    for (var i = 0; i < array.length; i++) {
        var item = array[i];
        console.log(item);
    }
    console.log("forEach")
    array.forEach((item) => {
        console.log(item);
    });

    console.log("map")
    array.map(item => {
        console.log(item);

    });

}
//arrow function
var diziDongu2 = () => {
    array.map((item, index,itself) => {
        console.log("Index: " + index + ": " + "Değer" + item);
        console.log("itself: " + itself);
    });
};

var a = [1,2,3,4,5,6,6,6,8,9,10,2,2]; //return 6
var b = [2,4,5,3,1,1,3,4,5,5]; //return 1
var c=  [];


function checkRepeat(array){
    
    for (var i = 0; i < array.length-1; i++)
    {
        if(array[i]==array[i+1]){
            console.log(array[i]);
            break;
            
        }
    }
//[1,2,4,4,2,1,4,4]
}
function firstRepeat(arr){
    var resArr = []

    for(let i=0; i<arr.length-1; i++){
        if(arr[i] === arr[i+1] && !resArr.includes(arr[i])){
            resArr.push(arr[i]);
            i++
        }
    }
    return resArr;
}

console.log(checkRepeat(a));
console.log(checkRepeat(b));





