import styles from './card.module.css';


export default async function Card(){

   const cards = await fetch('http://localhost:5285/api/Viagem').then(res => res.json());
    console.log(cards);

    return (
      <div className={styles.container}>
        {cards?.map((card) => (
          <div key={card.id} className={styles.card}>
            <img src='/superpromo.png'></img>
            <div className={styles.card_title}>
              <h2>{card.destino}</h2>
              <h3>🏨{card.tipoHospedagem}</h3>
              <h3>👥{card.qtdPessoas} Adultos</h3>
              <p>{card.descricao}</p>
              <h3 style={{color: 'green'}}>💰R$ {card.valor},00</h3>
            </div>
          </div>
        ))}
      </div>
    )
  
  }