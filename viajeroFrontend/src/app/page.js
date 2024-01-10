export default function Home() {
  return (
<>
  {/*Barra de Pesquisa*/}
  <div className="d-flex justify-content-center align-items-center">
    <div className="barra-pesquisa card custom-bg p-4 border border-3">
      <div className="d-flex align-items-center flex-wrap">
        {/* Origem */}
        <div className="form-group col-md mx-2">
          <label htmlFor="origin">
            <strong>Origem</strong>
          </label>
          <input
            type="text"
            placeholder="Cidade origem"
            className="form-control form-control-sm"
            id="origin"
            name="origin"
            required=""
          />
        </div>
        {/* Destino */}
        <div className="form-group col-md mx-2">
          <label htmlFor="depart">
            <strong>Destino</strong>
          </label>
          <input
            type="text"
            placeholder="Cidade destino"
            className="form-control form-control-sm"
            id="depart"
            name="depart"
            required=""
          />
        </div>
        {/* Ida */}
        <div className="form-group col-md mx-2">
          <label htmlFor="departure-date">
            <strong>Ida</strong>
          </label>
          <input
            type="date"
            className="form-control form-control-sm"
            id="departure-date"
            name="departure-date"
            onkeydown="return false"
            required=""
          />
        </div>
        {/* Volta */}
        <div className="form-group col-md mx-2">
          <label htmlFor="return-date">
            <strong>Volta</strong>
          </label>
          <input
            type="date"
            placeholder="One way"
            defaultValue=""
            className="form-control form-control-sm"
            id="return-date"
            name="return-date"
          />
        </div>
        {/* Botão de busca */}
        <div className="form-group col-md-auto mx-2 align-self-end">
          {/* Adicionando classe "btn-custom" para ajustar a margem do botão */}
          <button type="submit" className="btn btn-primary btn-sm btn-custom">
            🔎
          </button>
        </div>
      </div>
    </div>
  </div>
  {/*CARDS*/}
  <section className="ftco-section ftco-no-pt">
    <div className="container">
      <div className="row">
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/Undredal-Noruega.jpg"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Undredal - Noruega</h5>
              <p className="pacote-preco-antigo">R$ 10.759,00</p>
              <p className="pacote-preco-atual">R$ 8.226,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/Floripa.jpg"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Florianópolis - SC</h5>
              <p className="pacote-preco-antigo">R$ 1.999,00</p>
              <p className="pacote-preco-atual">R$ 1.183,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/Paraty-RJ.jpg"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Paraty - RJ</h5>
              <p className="pacote-preco-antigo">R$ 1.299,00</p>
              <p className="pacote-preco-atual">R$ 980,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/Salvador-BA.png"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Salvador - BA</h5>
              <p className="pacote-preco-antigo">R$ 2.699,00</p>
              <p className="pacote-preco-atual">R$ 1.505,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/baia-dos-porcos_fernando-de-noronha-770x515.jpg"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Fernando de Noronha - PE</h5>
              <p className="pacote-preco-antigo">R$ 4.699,00</p>
              <p className="pacote-preco-atual">R$ 3.255,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
        <div className="col-md-6 col-lg-4">
          <div className="card mb-4">
            <img
              className="card-img-top"
              src="/peru-machu-picchu.jpg"
              alt="Card image cap"
            />
            <div className="card-body">
              <h5 className="card-title">Machu Picchu - Peru</h5>
              <p className="pacote-preco-antigo">R$ 3.499,00</p>
              <p className="pacote-preco-atual">R$ 2.250,00</p>
              <a href="conferiroferta.html" className="input btn btn-primary">
                Conferir
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  {/*BARRA CENTRAL*/}
  <div className="barra-central">
    <div className="centralizar">
      <main className="conteudo">
        <h3 className="destaque"> Venha viajar conosco!</h3>
        <h2 className="destaque">
          {" "}
          Realizamos o seu sonho em apenas um click!
        </h2>
        <p className="destaque">
          {" "}
          O melhor <em>site de viagens</em> do Brasil!
        </p>
      </main>
    </div>
    {/*CARROSSEL*/}
    <div
      id="carouselExampleIndicators"
      className="carousel slide"
      data-bs-ride="carousel"
    >
      <div className="carousel-inner">
        <div className="carousel-item active">
          <img
            src="/Carrossel1.jpg"
            className="d-block w-100"
            alt="foto 1"
          />
        </div>
        <div className="carousel-item">
          <img
            src="/Carrossel4.jpg"
            className="d-block w-100"
            alt="foto 2"
          />
        </div>
        <div className="carousel-item">
          <img
            src="/Carrossel5.jpg"
            className="d-block w-100"
            alt="foto 3"
          />
        </div>
      </div>
      <a
        className="carousel-control-prev"
        href="#carouselExampleIndicators"
        role="button"
        data-bs-slide="prev"
      >
        <span className="carousel-control-prev-icon" aria-hidden="true" />
        <span className="visually-hidden">Anterior</span>
      </a>
      <a
        className="carousel-control-next"
        href="#carouselExampleIndicators"
        role="button"
        data-bs-slide="next"
      >
        <span className="carousel-control-next-icon" aria-hidden="true" />
        <span className="visually-hidden">Próximo</span>
      </a>
    </div>
  </div>
</>

  );
}
