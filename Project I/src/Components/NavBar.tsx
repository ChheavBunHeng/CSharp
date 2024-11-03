// NavBar.jsx

import { Link } from 'react-router-dom';  // Import Link from React Router
import SumiLogo from '../assets/Logo/Sumi Logo.jpg';

export default function NavBar() {
  const navLinks = [
    { name: 'Careers', path: '/careers' },  // Update to reflect routing
    { name: 'History', path: '/history' },
    { name: 'Product', path: './product' }
  ];

  return (
    <header className="">
  <div className="mx-auto max-w-screen-xl px-4 sm:px-6 lg:px-8">
    <div className="flex flex-col md:flex-row h-auto md:h-16 items-center justify-between md:justify-between py-4 md:py-0">
      {/* Logo Section */}
      <div className="flex justify-center md:justify-start flex-1 md:flex md:items-center md:gap-12">
        <Link to="/" className="block text-teal-600"> {/* Link to home */}
          <span className="sr-only">Home</span>
          <img
            src={SumiLogo}
            alt="Logo"
            className="p-1 w-[65px] h-[65px] hover:scale-110 transition duration-300"
          />
        </Link>
      </div>

      {/* Navigation Links */}
      <div className="md:flex md:items-center md:gap-12 mt-4 md:mt-0">
        <nav aria-label="Global">
          <ul className="flex flex-col md:flex-row items-center gap-6 text-sm">
            {navLinks.map((link) => (
              <li key={link.name}>
                <Link
                  to={link.path} // Use Link to navigate between pages
                  className="text-xl font-bold text-gray-500 transition hover:text-gray-500/75"
                >
                  {link.name}
                </Link>
              </li>
            ))}
          </ul>
        </nav>
      </div>
    </div>
  </div>
</header>
  );
}
