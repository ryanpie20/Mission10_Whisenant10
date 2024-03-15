import logo from "./bowlingleague.png";

function Header() {
  return (
    <header className="row">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" height="200" />
      </div>
      <div className="col subtitle">
        <h1>Bowling League</h1>
      </div>
    </header>
  );
}

export default Header;
