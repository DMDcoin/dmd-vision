using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.IStakingHbbft.ContractDefinition;

namespace DMDVision.Contracts.IStakingHbbft
{
    public partial class IStakingHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IStakingHbbftDeployment iStakingHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IStakingHbbftDeployment>().SendRequestAndWaitForReceiptAsync(iStakingHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IStakingHbbftDeployment iStakingHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IStakingHbbftDeployment>().SendRequestAsync(iStakingHbbftDeployment);
        }

        public static async Task<IStakingHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IStakingHbbftDeployment iStakingHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iStakingHbbftDeployment, cancellationTokenSource);
            return new IStakingHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IStakingHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> IncrementStakingEpochRequestAsync(IncrementStakingEpochFunction incrementStakingEpochFunction)
        {
             return ContractHandler.SendRequestAsync(incrementStakingEpochFunction);
        }

        public Task<string> IncrementStakingEpochRequestAsync()
        {
             return ContractHandler.SendRequestAsync<IncrementStakingEpochFunction>();
        }

        public Task<TransactionReceipt> IncrementStakingEpochRequestAndWaitForReceiptAsync(IncrementStakingEpochFunction incrementStakingEpochFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementStakingEpochFunction, cancellationToken);
        }

        public Task<TransactionReceipt> IncrementStakingEpochRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<IncrementStakingEpochFunction>(null, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string returnValue1, List<string> returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger returnValue5, BigInteger returnValue6, BigInteger returnValue7, List<byte[]> returnValue8, List<byte[]> returnValue9)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
                initializeFunction.ReturnValue5 = returnValue5;
                initializeFunction.ReturnValue6 = returnValue6;
                initializeFunction.ReturnValue7 = returnValue7;
                initializeFunction.ReturnValue8 = returnValue8;
                initializeFunction.ReturnValue9 = returnValue9;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string returnValue1, List<string> returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger returnValue5, BigInteger returnValue6, BigInteger returnValue7, List<byte[]> returnValue8, List<byte[]> returnValue9, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
                initializeFunction.ReturnValue5 = returnValue5;
                initializeFunction.ReturnValue6 = returnValue6;
                initializeFunction.ReturnValue7 = returnValue7;
                initializeFunction.ReturnValue8 = returnValue8;
                initializeFunction.ReturnValue9 = returnValue9;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> RemovePoolRequestAsync(RemovePoolFunction removePoolFunction)
        {
             return ContractHandler.SendRequestAsync(removePoolFunction);
        }

        public Task<TransactionReceipt> RemovePoolRequestAndWaitForReceiptAsync(RemovePoolFunction removePoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolFunction, cancellationToken);
        }

        public Task<string> RemovePoolRequestAsync(string returnValue1)
        {
            var removePoolFunction = new RemovePoolFunction();
                removePoolFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(removePoolFunction);
        }

        public Task<TransactionReceipt> RemovePoolRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var removePoolFunction = new RemovePoolFunction();
                removePoolFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolFunction, cancellationToken);
        }

        public Task<string> RemovePoolsRequestAsync(RemovePoolsFunction removePoolsFunction)
        {
             return ContractHandler.SendRequestAsync(removePoolsFunction);
        }

        public Task<string> RemovePoolsRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RemovePoolsFunction>();
        }

        public Task<TransactionReceipt> RemovePoolsRequestAndWaitForReceiptAsync(RemovePoolsFunction removePoolsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removePoolsFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RemovePoolsRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RemovePoolsFunction>(null, cancellationToken);
        }

        public Task<string> SetStakingEpochStartTimeRequestAsync(SetStakingEpochStartTimeFunction setStakingEpochStartTimeFunction)
        {
             return ContractHandler.SendRequestAsync(setStakingEpochStartTimeFunction);
        }

        public Task<TransactionReceipt> SetStakingEpochStartTimeRequestAndWaitForReceiptAsync(SetStakingEpochStartTimeFunction setStakingEpochStartTimeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingEpochStartTimeFunction, cancellationToken);
        }

        public Task<string> SetStakingEpochStartTimeRequestAsync(BigInteger returnValue1)
        {
            var setStakingEpochStartTimeFunction = new SetStakingEpochStartTimeFunction();
                setStakingEpochStartTimeFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(setStakingEpochStartTimeFunction);
        }

        public Task<TransactionReceipt> SetStakingEpochStartTimeRequestAndWaitForReceiptAsync(BigInteger returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var setStakingEpochStartTimeFunction = new SetStakingEpochStartTimeFunction();
                setStakingEpochStartTimeFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStakingEpochStartTimeFunction, cancellationToken);
        }

        public Task<byte[]> GetPoolPublicKeyQueryAsync(GetPoolPublicKeyFunction getPoolPublicKeyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolPublicKeyFunction, byte[]>(getPoolPublicKeyFunction, blockParameter);
        }

        
        public Task<byte[]> GetPoolPublicKeyQueryAsync(string poolAddress, BlockParameter blockParameter = null)
        {
            var getPoolPublicKeyFunction = new GetPoolPublicKeyFunction();
                getPoolPublicKeyFunction.PoolAddress = poolAddress;
            
            return ContractHandler.QueryAsync<GetPoolPublicKeyFunction, byte[]>(getPoolPublicKeyFunction, blockParameter);
        }

        public Task<GetPoolsLikelihoodOutputDTO> GetPoolsLikelihoodQueryAsync(GetPoolsLikelihoodFunction getPoolsLikelihoodFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolsLikelihoodFunction, GetPoolsLikelihoodOutputDTO>(getPoolsLikelihoodFunction, blockParameter);
        }

        public Task<GetPoolsLikelihoodOutputDTO> GetPoolsLikelihoodQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolsLikelihoodFunction, GetPoolsLikelihoodOutputDTO>(null, blockParameter);
        }

        public Task<List<string>> GetPoolsToBeElectedQueryAsync(GetPoolsToBeElectedFunction getPoolsToBeElectedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeElectedFunction, List<string>>(getPoolsToBeElectedFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsToBeElectedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeElectedFunction, List<string>>(null, blockParameter);
        }

        public Task<List<string>> GetPoolsToBeRemovedQueryAsync(GetPoolsToBeRemovedFunction getPoolsToBeRemovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeRemovedFunction, List<string>>(getPoolsToBeRemovedFunction, blockParameter);
        }

        
        public Task<List<string>> GetPoolsToBeRemovedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolsToBeRemovedFunction, List<string>>(null, blockParameter);
        }

        public Task<bool> IsPoolActiveQueryAsync(IsPoolActiveFunction isPoolActiveFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPoolActiveFunction, bool>(isPoolActiveFunction, blockParameter);
        }

        
        public Task<bool> IsPoolActiveQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isPoolActiveFunction = new IsPoolActiveFunction();
                isPoolActiveFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsPoolActiveFunction, bool>(isPoolActiveFunction, blockParameter);
        }

        public Task<BigInteger> MAX_CANDIDATESQueryAsync(MAX_CANDIDATESFunction mAX_CANDIDATESFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_CANDIDATESFunction, BigInteger>(mAX_CANDIDATESFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_CANDIDATESQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_CANDIDATESFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> OrderedWithdrawAmountQueryAsync(OrderedWithdrawAmountFunction orderedWithdrawAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OrderedWithdrawAmountFunction, BigInteger>(orderedWithdrawAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> OrderedWithdrawAmountQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var orderedWithdrawAmountFunction = new OrderedWithdrawAmountFunction();
                orderedWithdrawAmountFunction.ReturnValue1 = returnValue1;
                orderedWithdrawAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<OrderedWithdrawAmountFunction, BigInteger>(orderedWithdrawAmountFunction, blockParameter);
        }

        public Task<List<string>> PoolDelegatorsQueryAsync(PoolDelegatorsFunction poolDelegatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolDelegatorsFunction, List<string>>(poolDelegatorsFunction, blockParameter);
        }

        
        public Task<List<string>> PoolDelegatorsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var poolDelegatorsFunction = new PoolDelegatorsFunction();
                poolDelegatorsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolDelegatorsFunction, List<string>>(poolDelegatorsFunction, blockParameter);
        }

        public Task<bool> RewardWasTakenQueryAsync(RewardWasTakenFunction rewardWasTakenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RewardWasTakenFunction, bool>(rewardWasTakenFunction, blockParameter);
        }

        
        public Task<bool> RewardWasTakenQueryAsync(string returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null)
        {
            var rewardWasTakenFunction = new RewardWasTakenFunction();
                rewardWasTakenFunction.ReturnValue1 = returnValue1;
                rewardWasTakenFunction.ReturnValue2 = returnValue2;
                rewardWasTakenFunction.ReturnValue3 = returnValue3;
            
            return ContractHandler.QueryAsync<RewardWasTakenFunction, bool>(rewardWasTakenFunction, blockParameter);
        }

        public Task<BigInteger> StakeAmountQueryAsync(StakeAmountFunction stakeAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeAmountFunction, BigInteger>(stakeAmountFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeAmountQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeAmountFunction = new StakeAmountFunction();
                stakeAmountFunction.ReturnValue1 = returnValue1;
                stakeAmountFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeAmountFunction, BigInteger>(stakeAmountFunction, blockParameter);
        }

        public Task<BigInteger> StakeAmountTotalQueryAsync(StakeAmountTotalFunction stakeAmountTotalFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeAmountTotalFunction, BigInteger>(stakeAmountTotalFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeAmountTotalQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var stakeAmountTotalFunction = new StakeAmountTotalFunction();
                stakeAmountTotalFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<StakeAmountTotalFunction, BigInteger>(stakeAmountTotalFunction, blockParameter);
        }

        public Task<BigInteger> StakeFirstEpochQueryAsync(StakeFirstEpochFunction stakeFirstEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeFirstEpochFunction, BigInteger>(stakeFirstEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeFirstEpochQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeFirstEpochFunction = new StakeFirstEpochFunction();
                stakeFirstEpochFunction.ReturnValue1 = returnValue1;
                stakeFirstEpochFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeFirstEpochFunction, BigInteger>(stakeFirstEpochFunction, blockParameter);
        }

        public Task<BigInteger> StakeLastEpochQueryAsync(StakeLastEpochFunction stakeLastEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakeLastEpochFunction, BigInteger>(stakeLastEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakeLastEpochQueryAsync(string returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var stakeLastEpochFunction = new StakeLastEpochFunction();
                stakeLastEpochFunction.ReturnValue1 = returnValue1;
                stakeLastEpochFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<StakeLastEpochFunction, BigInteger>(stakeLastEpochFunction, blockParameter);
        }

        public Task<BigInteger> StakingWithdrawDisallowPeriodQueryAsync(StakingWithdrawDisallowPeriodFunction stakingWithdrawDisallowPeriodFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingWithdrawDisallowPeriodFunction, BigInteger>(stakingWithdrawDisallowPeriodFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingWithdrawDisallowPeriodQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingWithdrawDisallowPeriodFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingEpochQueryAsync(StakingEpochFunction stakingEpochFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochFunction, BigInteger>(stakingEpochFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingEpochQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingFixedEpochDurationQueryAsync(StakingFixedEpochDurationFunction stakingFixedEpochDurationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochDurationFunction, BigInteger>(stakingFixedEpochDurationFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingFixedEpochDurationQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochDurationFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StartTimeOfNextPhaseTransitionQueryAsync(StartTimeOfNextPhaseTransitionFunction startTimeOfNextPhaseTransitionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartTimeOfNextPhaseTransitionFunction, BigInteger>(startTimeOfNextPhaseTransitionFunction, blockParameter);
        }

        
        public Task<BigInteger> StartTimeOfNextPhaseTransitionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartTimeOfNextPhaseTransitionFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingFixedEpochEndTimeQueryAsync(StakingFixedEpochEndTimeFunction stakingFixedEpochEndTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochEndTimeFunction, BigInteger>(stakingFixedEpochEndTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingFixedEpochEndTimeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingFixedEpochEndTimeFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StakingEpochStartTimeQueryAsync(StakingEpochStartTimeFunction stakingEpochStartTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochStartTimeFunction, BigInteger>(stakingEpochStartTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> StakingEpochStartTimeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StakingEpochStartTimeFunction, BigInteger>(null, blockParameter);
        }
    }
}
