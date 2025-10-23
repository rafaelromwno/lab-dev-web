const TemplateExpression = () => {
  const nome = "Rafael"

    const data = {
        age: 19,
        job: 'Programador',
    }

  return (
    <div>
        Olá Seja Bem-Vindo {nome}!
        <p>Você atua como {data.job}</p>
    </div>
  )
}

export default TemplateExpression