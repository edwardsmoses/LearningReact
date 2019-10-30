
let data: number | string;


data = "2939";


export interface ICar{
    color:string;
    model:string;
    topSpeed?:number;
}


const car1 : ICar = {
    color : 'blue',
    model : 'BMW',
    topSpeed : 120
};

const car2 : ICar = {
    color : 'Red',
    model : 'Merceedes',
    topSpeed : 100
}

const car3 : ICar = {
    color : 'Green',
    model : 'Toyota'
}


const multiply = (x:number,y:number): number => {
    return (x*y) /100;
}

export const cars = [car1, car2, car3];