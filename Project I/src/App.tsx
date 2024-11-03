// App.tsx
import './App.css';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import NavBar from './Components/NavBar'; // Ensure correct casing
import Banner from './Components/Banner';
import Testimonial from './Components/Testimonial';
import Footer from './Components/Footer';
import History from './Components/Page/History';
import Careers from './Components/Page/Careers';
import Product from './Components/Page/Product';

function App() {
  return (
    <Router>
      <NavBar />  {/* Navbar will persist on all pages */}
      
      <Routes>
        {/* Define routes for each page */}
        <Route path="/" element={<Home />} />   {/* Home displays Banner */}
        <Route path="/history" element={<History />} />  {/* History page */}
        <Route path="/careers" element={<Careers />} />  {/* Careers page */}
        <Route path="/product" element={<Product />} />  {/* Product page */}
      </Routes>
      
      <Footer />
    </Router>
  );
}

function Home() {
  return (
    <>
      <Banner />
      <Testimonial /> {/* Testimonial only displayed on home page */}
    </>
  );
}

export default App;
