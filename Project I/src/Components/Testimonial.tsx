
export default function Testimonial() {
    return(
        <>
            {/*
  Heads up! 👋

  This component comes with some `rtl` classes. Please remove them if they are not needed in your project.
*/}

<section className="bg-gray-50">
  <div className="mx-auto max-w-screen-2xl px-4 py-12 sm:px-6 lg:px-8 lg:py-16">
    <div className="md:flex md:items-end md:justify-between">
      <div className="max-w-xl">
        <h2 className="text-4xl font-bold tracking-tight text-gray-900 sm:text-5xl">
          Our Manufacturing Excellence
        </h2>

        <p className="mt-6 max-w-lg leading-relaxed text-gray-700">
          For over a decade, we’ve specialized in delivering precision-engineered components to industries around the globe. 
          Our state-of-the-art facilities and dedicated workforce ensure the highest levels of quality and efficiency in every 
          product we create.
        </p>
      </div>

      <a
        href="#"
        className="mt-6 inline-flex shrink-0 items-center gap-2 rounded-full border border-blue-600 px-5 py-3 text-blue-600 transition hover:bg-blue-600 hover:text-white md:mt-0"
      >
        <span className="font-medium"> See Our Manufacturing Process </span>

        <svg
          xmlns="http://www.w3.org/2000/svg"
          className="size-4 rtl:rotate-180"
          fill="none"
          viewBox="0 0 24 24"
          stroke="currentColor"
        >
          <path
            strokeLinecap="round"
            strokeLinejoin="round"
            strokeWidth="2"
            d="M14 5l7 7m0 0l-7 7m7-7H3"
          />
        </svg>
      </a>
    </div>

    <div className="mt-8 grid grid-cols-1 gap-4 md:grid-cols-3">
      <blockquote className="flex h-full flex-col justify-between bg-white p-6 shadow-sm sm:p-8">
        <div>
          <div className="flex gap-0.5 text-green-500">
          </div>

          <div className="mt-4">
            <p className="text-2xl font-bold text-blue-600 sm:text-3xl">Innovative Production</p>

            <p className="mt-4 leading-relaxed text-gray-700">
            Our advanced manufacturing techniques allow us to optimize production while
            maintaining the strictest quality standards.
            </p>
          </div>
        </div>

        <footer className="mt-4 text-sm font-medium text-gray-700 sm:mt-6">
          &mdash; Author: — SCWS, Factory Manager
        </footer>
      </blockquote>

      <blockquote className="flex h-full flex-col justify-between bg-white p-6 shadow-sm sm:p-8">
        <div>
          <div className="flex gap-0.5 text-green-500">

          </div>

          <div className="mt-4">
            <p className="text-2xl font-bold text-blue-600 sm:text-3xl">Sustainable Practices" Description</p>

            <p className="mt-4 leading-relaxed text-gray-700">
            By integrating sustainable energy and eco-friendly materials into our workflow, 
            we prioritize environmental responsibility.
            </p>
          </div>
        </div>

        <footer className="mt-4 text-sm font-medium text-gray-700 sm:mt-6">
          &mdash; SCWS, Operations Director
        </footer>
      </blockquote>

      <blockquote className="flex h-full flex-col justify-between bg-white p-6 shadow-sm sm:p-8">
        <div>
          <div className="mt-4">
            <p className="text-2xl font-bold text-blue-600 sm:text-3xl">Client Satisfaction</p>

            <p className="mt-4 leading-relaxed text-gray-700">
            We take pride in building strong partnerships with our clients through timely deliveries and superior 
            product quality
            </p>
          </div>
        </div>

        <footer className="mt-4 text-sm font-medium text-gray-700 sm:mt-6">
          &mdash; SCWS, Client Relations Manager
        </footer>
      </blockquote>
    </div>
  </div>
</section>
        </>
    )

}