Easy Benchmarker
===============

Light-weight, standalone app for easy benchmarking of SCPI instruments.

![alt text](http://repo.tapalla.com/images/benchmarker0.png "Easy Benchmarker")

This app is used to benchmark measurements with the instrument set at a specific state.

### Example
**Benchmarking ACP Measurements**

1. Populate the fields
  * __VISA Address__ The VISA address of the instrument (e.g. tcpip0::ip_address::instr)
  * __State File Location__ The user must setup the instrument to the state they wish to benchmark. This can be done in two ways:
    1. Manually set the instrument to its desired state to benchmark, or
    2. Load a state file that will automatically setup the instrument
    
    For Option (2), check the box and point to the path of the state file on the host PC
  * __Benchmark Iterations__ Number of iterations the benchmark will be run. The __Measurement Time__ result at the bottom will be the average time of all the iterations.
  * __SCPI to Benchmark__ The SCPI command to benchmark. For this example we will be benchmarking `READ:ACP?`
2. Apply additional desired settings
  ![alt text](http://repo.tapalla.com/images/benchmarker1.png "Easy Benchmarker")
  * __Data Type__ This utility allows the data to be returned as binary data (REAL,32) instead of ASCII. SCPI queries that return relatively large data may benefit in terms of speed using binary data.
  * __Disable Display__ Turning off the instrument's display during testing can yield speed improvements
  * __Show Return Data__ If benchmarking a query, print out the last iteration's returned results  
