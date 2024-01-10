import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';


export default function Header() {
	return (
		<header className="header">
			<nav className="navbar navbar-expand-lg text-light">
  <div className="container-fluid">
    <a className="navbar-brand" href="index.html">
      <img
        width="60px"
        src="/logoteste.png"
        alt="Logotipo com um viajante de mochila nas costas"
      />
    </a>
    <button
      className="navbar-toggler"
      type="button"
      data-bs-toggle="collapse"
      data-bs-target="#navbarSupportedContent"
      aria-controls="navbarSupportedContent"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <span className="navbar-toggler-icon" />
    </button>
    <div className="collapse navbar-collapse" id="navbarSupportedContent">
      <ul className="navbar-nav me-auto mb-2 mb-lg-0">
        <li className="nav-item">
          <a
            className="nav-link active link-light"
            aria-current="page"
            href="/"
          >
            Início
          </a>
        </li>
        <li className="nav-item">
          <a className="nav-link link-light" href="/Promocoes">
            Promoções
          </a>
        </li>
        <li className="nav-item dropdown">
          <a
            className="nav-link dropdown-toggle link-light"
            href="/Destinos"
            role="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Destinos
          </a>
          <ul className="dropdown-menu">
            <li>
              <a className="dropdown-item" href="destinos.html#mais-visitados">
                Mais Visitados
              </a>
            </li>
            <li>
              <a className="dropdown-item" href="destinos.html#excursoes">
                Excursões
              </a>
            </li>
            <li>
              <a className="dropdown-item" href="destinos.html#internacionais">
                Internacionais
              </a>
            </li>
          </ul>
        </li>
        <li className="nav-item">
          <a className="nav-link link-light" href="/Contato">
            Contato
          </a>
        </li>
        <li className="nav-item dropdown">
          <a
            className="nav-link dropdown-toggle link-light "
            href="/Login"
            role="button"
            data-bs-toggle="dropdown"
            aria-expanded="false"
          >
            Login
          </a>
          <ul className="dropdown-menu">
            <li>
              <a className="dropdown-item" href="login.html">
                Entrar
              </a>
            </li>
            <li>
              <a className="dropdown-item" href="cadastro.html">
                Cadastrar-se
              </a>
            </li>
          </ul>
        </li>
      </ul>
    </div>
  </div>
  <div className="navbar-brand navbar-sticky-top">
    <span className="navbar-text">
      <h1 className="link-light nome-marca"> VIAJERO </h1>
    </span>
  </div>
</nav>

		</header>
	)
}