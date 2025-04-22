import logo from "../../assets/logo.png";
import person from "../../assets/person.svg";
import notification from "../../assets/notification.png";
import cart from "../../assets/cart.png";
import location from "../../assets/location.png";
import search from "../../assets/search.png";
import downArrow from "../../assets/down-arrow.svg";
import * as React from "react";
import "./Header.css";

const Header: React.FC = () => {
  return (
    <>
      <div className="col-12 header d-flex justify-content-between align-items-center  ">
        <div className="col-5 d-flex justify-content-around align-items-center ">
          <img src={logo} alt="Fresh & Local" />
          <div>
            <button className="link-button" type="button">
              <span>Shop By Category</span>
              <img title="downarrow" src={downArrow} alt="Down Arrow" />
            </button>
          </div>
          <div>
            <button className="link-button">Explore Farms</button>
          </div>
        </div>

        <div className="col-5 d-flex justify-content-evenly">
          <div className="col-2">
            <button className="link-button" type="button">
              <img src={search} alt="search" />
              Search
            </button>
          </div>
          <div className="col-3">
            <button className="link-button" type="button">
              <img src={location} alt="location" />
              Handiya 52700
            </button>
          </div>
          <div className="col-1">
            <button className="link-button" type="button">
              <img src={person} alt="Person" />
            </button>
          </div>
          <div className="col-1">
            <button className="link-button" type="button">
              <img src={notification} alt="notification" />
            </button>
          </div>
          <div className="col-1">
            <button className="link-button" type="button">
              <img src={cart} alt="cart" />
            </button>
          </div>
        </div>
      </div>
    </>
  );
}

export default Header;
