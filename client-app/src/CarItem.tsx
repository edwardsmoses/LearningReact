import React from 'react'
import { ICar } from './demo'


interface IProps{
    car: ICar
}

const CarItem:React.FC<IProps> = ({car}) => {
    return (
        <div>
            <span>{car.color}
             <small>
            {car.model}
                </small>
                <h5>{car.topSpeed}km/h</h5>
                </span>
               
        </div>
    )
}

export default CarItem
