
export default function Footer() {
    return (
        <div className="min-h-screen flex flex-col items-center">
            <h1 className="text-center font-bold text-3xl mb-6">History</h1>
            <div className="w-[80%] mx-auto flex flex-col">
                {/* Section 1 */}
                <div className="flex flex-col lg:flex-row w-full mb-4">
                    <div className="lg:w-2/3 p-6 bg-white text-black">
                        <h2 className="text-2xl font-semibold mb-4">Sumitomo Electric Industries</h2>
                        <p className="text-xl mb-4">
                            Sumitomo Electric Industries was founded in 1897 as a subsidiary of Sumitomo Mining Co., Ltd. Over the years, the company expanded its operations to include wire and cable manufacturing, becoming a global leader in the industry. This expertise in wire and cable production would later prove to be invaluable as Sumitomo Electric Industries entered the automotive sector.
                        </p>
                    </div>
                    <div className="lg:w-1/3 bg-gray-200 p-4 flex items-center justify-center">
                        <h2 className="w-full h-full bg-[url('https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Sumitomo_Electric_Industries_logo.svg/1920px-Sumitomo_Electric_Industries_logo.svg.png')] bg-no-repeat bg-contain bg-center"></h2>
                    </div>
                </div>

                {/* Section 2 */}
                <div className="flex flex-col lg:flex-row w-full mb-4">
                    <div className="lg:w-2/3 p-6 bg-white text-black">
                        <h2 className="text-2xl font-semibold mb-4">Sumi Cambodia Wiring Systems</h2>
                        <p className="text-xl mb-4">
                            Sumi Cambodia Wiring Systems was established in April 2012 as a subsidiary of Sumitomo Wiring Systems, a division of Sumitomo Electric Industries. The company's decision to invest in Cambodia was driven by several factors, including the favorable investment climate, abundant labor force, and proximity to key markets.
                        </p>
                    </div>
                    <div className="lg:w-1/3 bg-gray-200 p-4 flex items-center justify-center">
                        <h2 className="w-full h-full bg-[url('https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Sumitomo_Electric_Industries_logo.svg/1920px-Sumitomo_Electric_Industries_logo.svg.png')] bg-no-repeat bg-contain bg-center"></h2>
                    </div>
                </div>

                {/* Section 3 */}
                <div className="flex flex-col lg:flex-row w-full mb-4">
                    <div className="lg:w-2/3 p-6 bg-white text-black">
                        <h2 className="text-2xl font-semibold mb-4">Production Capacity</h2>
                        <p className="text-xl mb-4">
                            The company's first factory was established in the Royal Group Phnom Penh Special Economic Zone. Over time, Sumi Cambodia Wiring Systems expanded its operations, building two additional factories in [Location] and [Location]. These expansions allowed the company to significantly increase its production capacity and meet the growing demand for automotive wiring harnesses.
                        </p>
                    </div>
                    <div className="lg:w-1/3 bg-gray-200 p-4 flex items-center justify-center">
                        <h2 className="w-full h-full bg-[url('https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Sumitomo_Electric_Industries_logo.svg/1920px-Sumitomo_Electric_Industries_logo.svg.png')] bg-no-repeat bg-contain bg-center"></h2>
                    </div>
                </div>
            </div>
        </div>
    );
}
