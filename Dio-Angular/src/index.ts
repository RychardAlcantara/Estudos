type Hero = {
    name: string;
    power: string;
};

function Objetos(obj: Hero) {
    console.log(obj);
}

Objetos({
    name: "John Doe",
    power: "Super força"
 });

console.log("Ola mundo")