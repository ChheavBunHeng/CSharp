
export default function Footer(){
    return (
        <>
            <footer className="bg-white">
  <div className="mx-auto max-w-screen-xl px-4 pb-8 pt-16 sm:px-6 lg:px-8 lg:pt-24 text-center">
    <h2 className="text-3xl font-extrabold text-gray-900 sm:text-5xl">Customize Your SWES Product</h2>
    <p className="mx-auto mt-4 max-w-sm text-gray-500">Enhance your experience with our tailored solutions.</p>
    <a href="#" className="mt-8 inline-block rounded-full border border-blue-600 px-8 py-2 text-sm font-medium text-blue-600 hover:bg-blue-600 hover:text-white">
      Get Started
    </a>

    <div className="mt-16 border-t border-gray-100 pt-8">
      <ul className="flex flex-wrap justify-center gap-4 text-xs">
        <li><a href="#" className="text-gray-500 transition hover:opacity-75">Terms & Conditions</a></li>
        <li><a href="#" className="text-gray-500 transition hover:opacity-75">Privacy Policy</a></li>
      </ul>

      <ul className="mt-8 flex justify-center gap-6">
        <li>
          <a href="#" target="_blank" rel="noreferrer" className="text-gray-700 transition hover:opacity-75">
            <span className="sr-only">Facebook</span>
            {/* SVG Placeholder for Facebook */}
            <svg className="size-6" viewBox="0 0 24 24" aria-hidden="true">
              {/* Facebook icon path */}
            </svg>
          </a>
        </li>
        <li>
          <a href="#" target="_blank" rel="noreferrer" className="text-gray-700 transition hover:opacity-75">
            <span className="sr-only">Instagram</span>
            {/* SVG Placeholder for Instagram */}
            <svg className="size-6" viewBox="0 0 24 24" aria-hidden="true">
              {/* Instagram icon path */}
            </svg>
          </a>
        </li>
        <li>
          <a href="#" target="_blank" rel="noreferrer" className="text-gray-700 transition hover:opacity-75">
            <span className="sr-only">Twitter</span>
            {/* SVG Placeholder for Twitter */}
            <svg className="size-6" viewBox="0 0 24 24" aria-hidden="true">
              {/* Twitter icon path */}
            </svg>
          </a>
        </li>
      </ul>
    </div>
  </div>
</footer>

        </>
    );

}