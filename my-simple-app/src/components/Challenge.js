const Challenge = ({numero1, numero2}) => {

    const handleSum = () => {
        console.log(numero1 +  numero2)
    }

  return (
    <div>
        <h2>Challenge</h2>
        <h3>Número 1: {numero1}</h3>
        <h3>Número 2: {numero2}</h3>
        <button onClick={handleSum}>Somar no Console</button>
    </div>
  )
}

export default Challenge