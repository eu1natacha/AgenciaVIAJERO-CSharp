export default function Footer() {
	return (
		<footer className="footer">
			<div className="container">
  <div className="row mb-5">
    <div className="col-md">
      <div className="ftco-footer-widget mb-4 ml-md-5">
        <h2 className="ftco-heading-2">Pagamento</h2>
        <ul className="list-unstyled">
          <img width="300px" src="/asformasdepagamento.png" />
        </ul>
      </div>
    </div>
    <div className="col-md">
      <div className="ftco-footer-widget mb-4 ml-md-5">
        <h2 className="ftco-heading-2">Informações</h2>
        <ul className="list-unstyled">
          <li>
            <a
              href="destinos.html#mais-visitados"
              className="py-2 d-block text-black"
            >
              Mais visitados
            </a>
          </li>
          <li>
            <a
              href="destinos.html#excursoes"
              className="py-2 d-block text-black"
            >
              Excursões
            </a>
          </li>
          <li>
            <a
              href="destinos.html#internacionais"
              className="py-2 d-block text-black"
            >
              Viagens Internacionais
            </a>
          </li>
        </ul>
      </div>
    </div>
    <div className="col-md">
      <div className="ftco-footer-widget mb-4">
        <h2 className="ftco-heading-2">Fale Conosco</h2>
        <div className="block-23 mb-3">
          <ul>
            <dl>
              <i className="fas fa-map-marker-alt" />
              Rua Não Existente, 2023, Rio de Janeiro, RJ, Brasil
            </dl>
            <dl>
              <i className="fas fa-phone-alt" /> +55 21 1234 5678
            </dl>
            <dl>
              <i className="far fa-envelope" />
              queroviajar@viajero.com
            </dl>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <hr />
  <div className="row col-md-12 text-center text-black">
    <p>
      <img
        width="40px"
        src="/logoteste.png"
        alt="Logotipo com um viajante de mochila nas costas"
      />
      <b> VIAJERO</b> | Copyright © Todos os direitos reservados | Feito por{" "}
      <a href="https://github.com/eu1natacha" style={{ color: "black" }}>
        {" "}
        <strong>Natacha Carvalho</strong>
      </a>
    </p>
  </div>
</div>

		</footer>
	);
}